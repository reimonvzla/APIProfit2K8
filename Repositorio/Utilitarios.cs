namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class Utilitarios
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        readonly DocumentosVentasRepositorio DocumCCRepositorio = new DocumentosVentasRepositorio();
        readonly MovimientosCajaRepositorio MovCRepositorio = new MovimientosCajaRepositorio();
        readonly MovimientosBancoRepositorio MovBRepositorio = new MovimientosBancoRepositorio();
        int valor = 0;

        #region Buscar consecutivo de documento
        public int BuscarConsecutivo(string tipoDoc, string sucursal_act, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            int numero = 0;

            #region Verificar si maneja sucursales
            if (db.ParEmp.Select(p => p.PFactAlm).FirstOrDefault())
            {
                Almacen obj = db.Almacen.FirstOrDefault(a => a.CoAlma == sucursal_act);
                numero = BuscarCampoProximoNumeroTabla(obj, tipoDoc);
            }
            else
            {
                ParEmp obj = db.ParEmp.FirstOrDefault();
                numero = BuscarCampoProximoNumeroTabla(obj, tipoDoc);
            }
            #endregion

            #region Buscar consecutivo en tablas
            while (true)
            {
                #region Busqueda movimientos en documentos
                if (tipoDoc != "COBR" && tipoDoc != "MOVC" && tipoDoc != "MOVB")
                {
                    DocumCc documcc = DocumCCRepositorio.GetDocumento(numero, tipoDoc, empresaDB);
                    if (documcc != null)
                    {
                        numero++;
                    }
                    else
                    {
                        break;
                    }
                }
                #endregion

                #region Busqueda movimientos en cobros
                if (tipoDoc == "COBR")
                {
                    //EncabCobro cobro = cobrosRepositorio.Find(numero, empresaDB);
                    Cobros cobro = db.Cobros.FirstOrDefault(c => c.CobNum == numero);
                    if (cobro != null)
                    {
                        numero++;
                    }
                    else
                    {
                        break;
                    }
                }
                #endregion

                #region Busqueda movimientos en caja
                if (tipoDoc == "MOVC")
                {
                    MovCaj movcaja = MovCRepositorio.Find(numero, empresaDB);
                    if (movcaja != null)
                    {
                        numero++;
                    }
                    else
                    {
                        break;
                    }
                }
                #endregion

                #region Busqueda movimientos en bancos
                if (tipoDoc == "MOVB")
                {
                    MovBan movbanco = MovBRepositorio.Find(numero, empresaDB);
                    if (movbanco != null)
                    {
                        numero++;
                    }
                    else
                    {
                        break;
                    }
                } 
                #endregion

            }
            #endregion

            return numero;
        }
        #endregion

        #region Buscar consecutivo de numero de control
        public string BuscarNroControl(string sucursal_act, string EmpresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(EmpresaDB));

            string prefijo = string.Empty, numeroc = string.Empty;
            string mask = string.Empty;

            #region Verificar si maneja sucursales
            if (db.ParEmp.Select(p => p.PFactAlm).FirstOrDefault())
            {
                Almacen obj = db.Almacen.FirstOrDefault(a => a.CoAlma == sucursal_act);

                if(string.IsNullOrEmpty(obj.Campo3.Trim()))
                {
                    throw new ArgumentException($"No existe configurado el prefijo del número de control en la sucursal {sucursal_act.Trim()} (Campo3)");
                }

                if (string.IsNullOrEmpty(obj.Campo4.Trim()))
                {
                    throw new ArgumentException($"No existe configurado el número de control en la sucursal {sucursal_act.Trim()} (Campo4)");
                }

                prefijo = obj.Campo3.Trim();

                var len = obj.Campo4.Trim().Length;
                var con = Convert.ToInt32(obj.Campo4.Trim()) + 1;

                mask = new String('0', len); 
                numeroc = con.ToString($"{mask}");
            }
            #endregion            
            
            else

            #region Buscar en Configuracion adicional de la empresa la carpeta correspondiente (NroControl).
            {
                List<Auxiliar> NroControl = (from control in db.Auxiliar where control.GrupAux == "NroControl" select control).ToList();
                if (NroControl.Count == 0)
                {
                    throw new ArgumentException("No existe la carpeta 'NroControl' configurada en datos adicionales de la empresa.");
                }
                else
                {
                    foreach (var iControl in NroControl)
                    {
                        switch (iControl.NomAux.Trim())
                        {
                            case "Prefijo":
                                mask = iControl.FormAux.Trim().Replace("9", "0");
                                prefijo = (Convert.ToInt32(iControl.ValAux.Trim())).ToString($"{mask}");
                                //prefijo = $"{(Convert.ToInt32(iControl.ValAux.Trim()) + 1): 00 }";
                                break;
                            case "Control":
                                mask = iControl.FormAux.Trim().Replace("9", "0");
                                numeroc = (Convert.ToInt32(iControl.ValAux.Trim()) + 1).ToString($"{mask}");
                                //numeroc = $"{(Convert.ToInt32(iControl.ValAux.Trim()) + 1): 000000}";
                                break;
                            default:
                                break;
                        }
                    }
                }
            } 
            #endregion
            
            return $@"{prefijo}-{numeroc}".Trim();
        }
        #endregion

        #region Buscar el campo y proximo numero en la tabla que se este evaluando
        private int BuscarCampoProximoNumeroTabla(object obj, string tipoDoc)
        {
            /*Ubica dinamicamente el valor del campo sea ParEmp o Almacen el que se este evaluando*/
            switch (tipoDoc)
            {
                case "FACT":
                    valor = (int)obj.GetType().GetProperty("FactNum").GetValue(obj, null);
                    break;
                case "COBR":
                    valor = (int)obj.GetType().GetProperty("CbNum").GetValue(obj, null);
                    break;
                case "MOVC":
                    valor = (int)obj.GetType().GetProperty("MovcNum").GetValue(obj, null);
                    break;
                case "MOVB":
                    valor = (int)obj.GetType().GetProperty("MovbNum").GetValue(obj, null);
                    break;
                default:
                    break;
            }
            return valor + 1;
        } 
        #endregion

        #region Armar DisCen
        public string ArmarDisCen(DateTime FechaDocumento, decimal BaseImp, decimal IvaTotal, decimal ExentoTotal, string EmpresaDB)
        {
            decimal TasaIVA = BuscarISV("1", FechaDocumento, "V", EmpresaDB);
            string DisCen;
            string Enter = "\r"; //(char)13

            if (ExentoTotal <= 0)
            {
                DisCen = $@"{Enter}<IVA>{Enter}<1>{TasaIVA}/{BaseImp}/{IvaTotal}</1>{Enter}{Enter}</IVA>{Enter}";
            }
            else
            {
                DisCen = $@"{Enter}<IVA>{Enter}<E>{ExentoTotal}</E>{Enter}<1>{TasaIVA}/{BaseImp}/{IvaTotal}</1>{Enter}{Enter}</IVA>{Enter}";
            }

            return DisCen;
        }
        #endregion

        #region BuscarISV
        private decimal BuscarISV(string tipoTasa, DateTime fecha, string tipoDoc, string EmpresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(EmpresaDB));
            var Qry = (from tab in
                           db.TabEnc
                           .Where(t => tipoDoc == "V" ? t.TipoImp == 1 : t.TipoImp == 2 && t.Fecha >= fecha)
                       orderby tab.Fecha descending
                       select tipoTasa == "1" ? tab.Tasa : tipoTasa == "2" ? tab.Tasag10 : tab.Tasag20).Take(1);
            return Qry.FirstOrDefault();
        }
        #endregion

        #region Calcular exento factura
        public decimal TotalExento(ICollection<DetaFacturaVenta> DetalleFactura, string EmpresaDB)
        {
            var Qry = (from exento in DetalleFactura where exento.TipoImp == "6" select exento).Sum(t => t.RengNeto);
            return Qry;
        }
        #endregion

        #region Actualizar stock articulo
        public void ActualizarStockArticuloAlmacen(string CodigoArticulo, string CodigoAlmacen, decimal Cantidad, bool SumaStock, string EmpresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(EmpresaDB));

                Art ArtVentaServicio = db.Art.FirstOrDefault(a => a.CoArt == CodigoArticulo);
                bool result;

                if (ArtVentaServicio.Tipo == "V")
                {
                    var StockxAlmacen = db.StAlmac.FirstOrDefault(a => a.CoArt == ArtVentaServicio.CoArt && a.CoAlma == CodigoAlmacen);

                    decimal StockNuevo = (Cantidad * (SumaStock ? 1 : -1));

                    if (StockxAlmacen != null)
                    {
                        #region Actualizando stock en almacen
                        StockxAlmacen.StockAct += StockNuevo;
                        db.Entry(StockxAlmacen).State = EntityState.Modified;
                        db.SaveChanges();
                        result = true;
                        #endregion
                    }
                    else
                    {
                        #region Agregar nuevo stock en almacen
                        StAlmac NuevoStAlmac = new StAlmac
                        {
                            CoAlma = CodigoAlmacen,
                            CoArt = CodigoArticulo,
                            StockAct = StockNuevo
                        };
                        db.Entry(NuevoStAlmac).State = EntityState.Added;
                        db.SaveChanges();
                        result = true;
                        #endregion
                    }

                    #region Actualizando stock en articulo
                    if (result) // Validar que la transacción anterior se haya completado
                    {
                        ArtVentaServicio.StockAct += StockNuevo;
                        db.Entry(ArtVentaServicio).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    #endregion

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        #endregion

        #region Actualizar consecutivo
        public void ActualizarConsecutivo(int numero, string tipoDoc, string sucursal_act,string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            if (db.ParEmp.Select(p => p.PFactAlm).FirstOrDefault())
            {
                Almacen obj = db.Almacen.FirstOrDefault(a => a.CoAlma == sucursal_act);
                ActualizarNumeroConsecutivoTabla(obj, numero, tipoDoc, empresaDB);
            }
            else
            {
                ParEmp obj = db.ParEmp.FirstOrDefault();
                ActualizarNumeroConsecutivoTabla(obj, numero, tipoDoc, empresaDB);
            }
        }
        #endregion

        #region Actualizar nro control
        public void ActualizarNroControl(string numeroc,string sucursal_act,string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            string valor = string.Empty;

            if (db.ParEmp.Select(p => p.PFactAlm).FirstOrDefault())
            {
                Almacen obj = db.Almacen.FirstOrDefault(a => a.CoAlma == sucursal_act);
                valor = numeroc.Substring(numeroc.IndexOf("-") + 1, numeroc.Length - (numeroc.IndexOf("-") + 1));
                obj.Campo4 = valor;
            }
            else
            {
                List<Auxiliar> NroControl = (from control in db.Auxiliar where control.GrupAux == "NroControl" select control).ToList();
                foreach (var iNroControl in NroControl)
                {
                    switch (iNroControl.NomAux.Trim())
                    {
                        case "Control":
                            valor = Convert.ToInt32(numeroc.Substring(numeroc.IndexOf("-") + 1, numeroc.Length - (numeroc.IndexOf("-") + 1))).ToString();
                            break;
                        case "Prefijo":
                            valor = Convert.ToInt32(numeroc.Substring(0, numeroc.IndexOf("-"))).ToString();
                            break;
                        default:
                            break;
                    }
                    iNroControl.ValAux = valor;
                    db.Entry(iNroControl).State = EntityState.Modified;
                }
            }
            db.SaveChanges();
        }
        #endregion

        #region Actualizar numero consecutivo en tabla
        private void ActualizarNumeroConsecutivoTabla(object tabla, int numero, string tipoDoc, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            switch (tipoDoc)
            {
                case "FACT":
                    tabla.GetType().GetProperty("FactNum").SetValue(tabla, numero);
                    break;
                case "COBR":
                    tabla.GetType().GetProperty("CbNum").SetValue(tabla, numero);
                    break;
                case "MOVC":
                    tabla.GetType().GetProperty("MovcNum").SetValue(tabla, numero);
                    break;
                case "MOVB":
                    tabla.GetType().GetProperty("MovbNum").SetValue(tabla, numero);
                    break;
                default:
                    break;
            }
            db.Entry(tabla).State = EntityState.Modified;
            db.SaveChanges();
        }
        #endregion

        #region Verificar moneda
        public Moneda GetMoneda(string codMoneda,string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

            Moneda moneda = db.Moneda.FirstOrDefault(m => m.CoMone.Trim() == codMoneda.Trim());
            if (moneda == null)
            {
                throw new ArgumentException($"La moneda indicada {codMoneda.Trim()} no existe.");
            }
            return moneda;
        }
        #endregion

        #region Verificar sucursal
        public Almacen GetSucursal(string codSucursal, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            Almacen sucu = db.Almacen.FirstOrDefault(s => s.CoAlma.Trim() == codSucursal.Trim());
            if (sucu == null)
            {
                throw new ArgumentException($"La sucursal {codSucursal.Trim()} indicada no existe.");
            }
            return sucu;
        } 
        #endregion

    }
}