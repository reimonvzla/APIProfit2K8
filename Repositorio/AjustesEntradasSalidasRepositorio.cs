namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class AjustesEntradasSalidasRepositorio : IRepositorio<EncabAjuste>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        
        #region Find
        public EncabAjuste Find(int key, string empresaDB)
        {
            /* Se puede hacer un simple join pero no en coleccion de memoria, de por si nunca los joins fueron 
             * soportados en coleciones de memoria. Solo EF Core 1.x / 2.x 
             * usó llamadas de evaluacion de cliente para cosas que no se podian traducir.
             * Pero dicha evaluación implícita del cliente se eliminó en esta versión (3.1) 
             * ahora se supone que se debe encontrar un constructor traducible o cambiar 
             * explícitamente a la evaluación del cliente a través de LINQ. por lo que se realizó de esta forma la consulta. 
             * generalmente esto era una sola línea...
             */

            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            EncabAjuste ajuste = db.Ajuste.Select(a => new EncabAjuste
            {
                #region Campos
                AjueNum = a.AjueNum,
                Fecha = a.Fecha,
                Motivo = a.Motivo,
                Total = a.Total,
                Seriales = a.Seriales,
                Feccom = a.Feccom,
                Numcom = a.Numcom,
                Tasa = a.Tasa,
                Moneda = a.Moneda,
                DisCen = a.DisCen,
                Campo1 = a.Campo1,
                Campo2 = a.Campo2,
                Campo3 = a.Campo3,
                Campo4 = a.Campo4,
                Campo5 = a.Campo5,
                Campo6 = a.Campo6,
                Campo7 = a.Campo7,
                Campo8 = a.Campo8,
                CoUsIn = a.CoUsIn,
                FeUsIn = a.FeUsIn,
                CoUsMo = a.CoUsMo,
                FeUsMo = a.FeUsMo,
                CoUsEl = a.CoUsEl,
                FeUsEl = a.FeUsEl,
                Revisado = a.Revisado,
                Trasnfe = a.Trasnfe,
                CoSucu = a.CoSucu,
                Rowguid = a.Rowguid,
                Anulada = a.Anulada,
                Aux01 = a.Aux01,
                Aux02 = a.Aux02,
                Produccion = a.Produccion,
                ImpNum = a.ImpNum,
                FactNum = a.FactNum 
                #endregion
            
            }).FirstOrDefault(a => a.AjueNum == key);

            List<DetaAjuste> reng = (from da in db.RengAju
                                     where da.AjueNum == ajuste.AjueNum
                                     orderby da.RengNum ascending
                                     select new DetaAjuste()
                                     {
                                         #region Campos
                                         AjueNum = da.AjueNum,
                                         RengNum = da.RengNum,
                                         DisCen = da.DisCen,
                                         Tipo = da.Tipo,
                                         CoArt = da.CoArt,
                                         TotalArt = da.TotalArt,
                                         UniCompra = da.UniCompra,
                                         StotalArt = da.StotalArt,
                                         SuniCompr = da.SuniCompr,
                                         CoAlma = da.CoAlma,
                                         CostUnitOm = da.CostUnitOm,
                                         CostUnit = da.CostUnit,
                                         Feccom = da.Feccom,
                                         Numcom = da.Numcom,
                                         UniVenta = da.UniVenta,
                                         SuniVenta = da.SuniVenta,
                                         CosProUn = da.CosProUn,
                                         UltCosOm = da.UltCosOm,
                                         CosProOm = da.CosProOm,
                                         Rowguid = da.Rowguid,
                                         TotalUni = da.TotalUni,
                                         NroLote = da.NroLote,
                                         FecLote = da.FecLote,
                                         Pendiente2 = da.Pendiente2,
                                         TipoDoc2 = da.TipoDoc2,
                                         RengDoc2 = da.RengDoc2,
                                         NumDoc2 = da.NumDoc2,
                                         Aux01 = da.Aux01,
                                         Aux02 = da.Aux02,
                                         MoCant = da.MoCant,
                                         GfCant = da.GfCant,
                                         MoCantOm = da.MoCantOm,
                                         GfCantOm = da.GfCantOm,
                                         Produccion = da.Produccion 
                                         #endregion
                                     
                                     }).ToList();
            ajuste.DetaAjuste = reng;
            return ajuste;
        }
        #endregion

        #region GetAll
        public IEnumerable<EncabAjuste> GetAll(string empresaDB)
        {
            /* Se puede hacer un simple join pero no en coleccion de memoria, de por si nunca los joins fueron 
             * soportados en coleciones de memoria. Solo EF Core 1.x / 2.x 
             * usó llamadas de evaluacion de cliente para cosas que no se podian traducir.
             * Pero dicha evaluación implícita del cliente se eliminó en esta versión (3.1) 
             * ahora se supone que se debe encontrar un constructor traducible o cambiar 
             * explícitamente a la evaluación del cliente a través de LINQ. por lo que se realizó de esta forma la consulta. 
             * generalmente esto era una sola línea...
             */

            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            List<EncabAjuste> ajuste = db.Ajuste.Select(a => new EncabAjuste
            {
                #region Campos
                AjueNum = a.AjueNum,
                Fecha = a.Fecha,
                Motivo = a.Motivo,
                Total = a.Total,
                Seriales = a.Seriales,
                Feccom = a.Feccom,
                Numcom = a.Numcom,
                Tasa = a.Tasa,
                Moneda = a.Moneda,
                DisCen = a.DisCen,
                Campo1 = a.Campo1,
                Campo2 = a.Campo2,
                Campo3 = a.Campo3,
                Campo4 = a.Campo4,
                Campo5 = a.Campo5,
                Campo6 = a.Campo6,
                Campo7 = a.Campo7,
                Campo8 = a.Campo8,
                CoUsIn = a.CoUsIn,
                FeUsIn = a.FeUsIn,
                CoUsMo = a.CoUsMo,
                FeUsMo = a.FeUsMo,
                CoUsEl = a.CoUsEl,
                FeUsEl = a.FeUsEl,
                Revisado = a.Revisado,
                Trasnfe = a.Trasnfe,
                CoSucu = a.CoSucu,
                Rowguid = a.Rowguid,
                Anulada = a.Anulada,
                Aux01 = a.Aux01,
                Aux02 = a.Aux02,
                Produccion = a.Produccion,
                ImpNum = a.ImpNum,
                FactNum = a.FactNum
                #endregion

            }).ToList();

            for (int r = 0; r < ajuste.Count; r++)
            {
                List<DetaAjuste> reng = (from da in db.RengAju
                                         where da.AjueNum == ajuste[r].AjueNum
                                         orderby da.RengNum ascending
                                         select new DetaAjuste()
                                         {
                                             #region Campos
                                             AjueNum = da.AjueNum,
                                             RengNum = da.RengNum,
                                             DisCen = da.DisCen,
                                             Tipo = da.Tipo,
                                             CoArt = da.CoArt,
                                             TotalArt = da.TotalArt,
                                             UniCompra = da.UniCompra,
                                             StotalArt = da.StotalArt,
                                             SuniCompr = da.SuniCompr,
                                             CoAlma = da.CoAlma,
                                             CostUnitOm = da.CostUnitOm,
                                             CostUnit = da.CostUnit,
                                             Feccom = da.Feccom,
                                             Numcom = da.Numcom,
                                             UniVenta = da.UniVenta,
                                             SuniVenta = da.SuniVenta,
                                             CosProUn = da.CosProUn,
                                             UltCosOm = da.UltCosOm,
                                             CosProOm = da.CosProOm,
                                             Rowguid = da.Rowguid,
                                             TotalUni = da.TotalUni,
                                             NroLote = da.NroLote,
                                             FecLote = da.FecLote,
                                             Pendiente2 = da.Pendiente2,
                                             TipoDoc2 = da.TipoDoc2,
                                             RengDoc2 = da.RengDoc2,
                                             NumDoc2 = da.NumDoc2,
                                             Aux01 = da.Aux01,
                                             Aux02 = da.Aux02,
                                             MoCant = da.MoCant,
                                             GfCant = da.GfCant,
                                             MoCantOm = da.MoCantOm,
                                             GfCantOm = da.GfCantOm,
                                             Produccion = da.Produccion
                                             #endregion

                                         }).ToList();
                ajuste[r].DetaAjuste = reng;

            }
            return ajuste;
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(EncabAjuste item, string empresaDB)
        {
            try
            {
                Utilitarios utilitarios = new Utilitarios();
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                #region Validar ajuste
                ValidarAjuste(item, empresaDB);
                #endregion

                #region Buscar consecutivo
                int numeroAjuste = utilitarios.BuscarConsecutivo("AJUS", item.CoSucu, empresaDB);
                #endregion

                if (numeroAjuste > 0)
                {
                    db.Entry(new Ajuste 
                    {
                        #region Campos
                        AjueNum = numeroAjuste,
                        Fecha = item.Fecha,
                        Motivo = item.Motivo,
                        Total = item.Total,
                        Seriales = item.Seriales,
                        Feccom = item.Feccom,
                        Numcom = item.Numcom,
                        Tasa = item.Tasa,
                        Moneda = item.Moneda,
                        DisCen = item.DisCen,
                        Campo1 = item.Campo1,
                        Campo2 = item.Campo2,
                        Campo3 = item.Campo3,
                        Campo4 = item.Campo4,
                        Campo5 = item.Campo5,
                        Campo6 = item.Campo6,
                        Campo7 = item.Campo7,
                        Campo8 = item.Campo8,
                        CoUsIn = item.CoUsIn,
                        FeUsIn = item.FeUsIn,
                        CoUsMo = item.CoUsMo,
                        FeUsMo = item.FeUsMo,
                        CoUsEl = item.CoUsEl,
                        FeUsEl = item.FeUsEl,
                        Revisado = item.Revisado,
                        Trasnfe = item.Trasnfe,
                        CoSucu = item.CoSucu,
                        Rowguid = item.Rowguid,
                        Anulada = item.Anulada,
                        Aux01 = item.Aux01,
                        Aux02 = item.Aux02,
                        Produccion = item.Produccion,
                        ImpNum = item.ImpNum,
                        FactNum = item.FactNum
                        #endregion

                    }).State = EntityState.Added;

                    foreach (var iAjusteReng in item.DetaAjuste)
                    {
                        db.Entry(new RengAju
                        {
                            #region Campos
                            AjueNum = numeroAjuste,
                            RengNum = iAjusteReng.RengNum,
                            DisCen = iAjusteReng.DisCen,
                            Tipo = iAjusteReng.Tipo,
                            CoArt = iAjusteReng.CoArt,
                            TotalArt = iAjusteReng.TotalArt,
                            UniCompra = iAjusteReng.UniCompra,
                            StotalArt = iAjusteReng.StotalArt,
                            SuniCompr = iAjusteReng.SuniCompr,
                            CoAlma = iAjusteReng.CoAlma,
                            CostUnitOm = iAjusteReng.CostUnitOm,
                            CostUnit = iAjusteReng.CostUnit,
                            Feccom = iAjusteReng.Feccom,
                            Numcom = iAjusteReng.Numcom,
                            UniVenta = iAjusteReng.UniVenta,
                            SuniVenta = iAjusteReng.SuniVenta,
                            CosProUn = iAjusteReng.CosProUn,
                            UltCosOm = iAjusteReng.UltCosOm,
                            CosProOm = iAjusteReng.CosProOm,
                            Rowguid = iAjusteReng.Rowguid,
                            TotalUni = iAjusteReng.TotalUni,
                            NroLote = iAjusteReng.NroLote,
                            FecLote = iAjusteReng.FecLote,
                            Pendiente2 = iAjusteReng.Pendiente2,
                            TipoDoc2 = iAjusteReng.TipoDoc2,
                            RengDoc2 = iAjusteReng.RengDoc2,
                            NumDoc2 = iAjusteReng.NumDoc2,
                            Aux01 = iAjusteReng.Aux01,
                            Aux02 = iAjusteReng.Aux02,
                            MoCant = iAjusteReng.MoCant,
                            GfCant = iAjusteReng.GfCant,
                            MoCantOm = iAjusteReng.MoCantOm,
                            GfCantOm = iAjusteReng.GfCantOm,
                            Produccion = iAjusteReng.Produccion
                            #endregion

                        }).State = EntityState.Added;

                        #region Actualización de stock

                        #region Saber si el tipo de ajuste del renglon es de entrada o salida.
                        var TipoAjuste = db.TipoAju.FirstOrDefault(t => t.CoTipo.Trim() == iAjusteReng.Tipo.Trim()).TipoTrans;
                        #endregion

                        utilitarios.ActualizarStockArticuloAlmacen(iAjusteReng.CoArt, iAjusteReng.CoAlma, iAjusteReng.TotalArt, (TipoAjuste == "E"), empresaDB);
                        #endregion

                        #region Actualización de costos en articulo
                        
                        #region Valor de la tasa OM parametrizada.
                        decimal tasa = db.Moneda.FirstOrDefault(m => m.CoMone.Trim() == db.ParEmp.FirstOrDefault().MoneArt.Trim()).Cambio;
                        #endregion

                        Art art = db.Art.FirstOrDefault(a => a.CoArt.Trim() == iAjusteReng.CoArt.Trim());
                        art.CosProUn = iAjusteReng.CostUnit;
                        art.FecCosPr = DateTime.Now;
                        art.CosProOm = iAjusteReng.CostUnit / tasa;
                        art.FecProOm = DateTime.Now;

                        art.CosUnAn = art.UltCosUn;
                        art.FecCosAn = art.FecUltCo;
                        art.UltCosUn = iAjusteReng.CostUnit;
                        art.FecUltCo = DateTime.Now;

                        art.UltCosDo = art.UltCosOm;
                        art.FecCosDo = art.FecUltOm;
                        art.UltCosOm = iAjusteReng.CostUnit / tasa;
                        art.FecUltOm = DateTime.Now;

                        art.CoUsMo = item.CoUsMo;
                        art.FeUsMo = DateTime.Now;

                        db.Entry(art).State = EntityState.Modified; 
                        #endregion
                    }
                    db.SaveChanges();

                    #region Actualizacion de consecutivo
                    utilitarios.ActualizarConsecutivo(numeroAjuste, "AJUS", item.CoSucu, empresaDB);
                    #endregion

                    return new Response { Status = "OK", Message = "Transacción realizada con éxito." };
                }
                else
                {
                    throw new ArgumentException("No se encontró el correlativo configurado para 'AJUS'.");
                }
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Update
        public Response Update(EncabAjuste item, string empresaDB)
        {
            throw new NotImplementedException();
            
            #region No se implementa
            //try
            //{
            //    using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            //    db.Entry(item).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return new Response { Status = "OK", Message = "Actualización realizada con éxito." };
            //}
            //catch (Exception ex)
            //{
            //    return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            //} 
            #endregion
        }
        #endregion

        #region Validar ajuste
        private void ValidarAjuste(EncabAjuste obj, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

            #region Verificar sucursal
            new Utilitarios().GetSucursal(obj.CoSucu, empresaDB);
            #endregion

            #region Verficar renglones
            foreach (var iRengAju in obj.DetaAjuste)
            {
                #region Verificar articulo
                Art articulo = new ArticulosRepositorio().Find(iRengAju.CoArt, empresaDB);
                if (articulo == null)
                {
                    throw new ArgumentException($"El artículo {iRengAju.CoArt.Trim()} indicado en el renglón {iRengAju.RengNum} del ajuste no existe.");
                }
                #endregion

                #region Verificar cantidad
                if (iRengAju.TotalArt <= 0) throw new ArgumentException($"Cantidad indicada en el renglón {iRengAju.RengNum} es inválida. (Valor indicado: {iRengAju.TotalArt}).");
                #endregion

                #region Verificar unidad primaria
                Unidades unidadPpal = db.Unidades.FirstOrDefault(u => u.CoUni.Trim() == iRengAju.UniVenta.Trim());
                if (unidadPpal == null) throw new ArgumentException($"La unidad primaria indicada en el renglón {iRengAju.RengNum} no existe.");
                #endregion

                #region Verificar unidad secundaria
                Unidades unidadSecd = db.Unidades.FirstOrDefault(u => u.CoUni.Trim() == iRengAju.SuniCompr.Trim());
                if (unidadSecd == null) throw new ArgumentException($"La unidad secundaria indicada en el renglón {iRengAju.RengNum} no existe.");
                #endregion

                #region Verificar almacen
                SubAlma almacen = db.SubAlma.FirstOrDefault(a => a.CoSub == iRengAju.CoAlma);
                if (almacen == null)
                {
                    throw new ArgumentException($"El almacén {iRengAju.CoAlma.Trim()} suministrado en el renglón {iRengAju.RengNum} no existe.");
                }
                else
                {
                    if (almacen.CoAlma.Trim() != obj.CoSucu.Trim())
                    {
                        throw new ArgumentException($"El almacén {iRengAju.CoAlma.Trim()} suministrado en el renglón {iRengAju.RengNum} no está permitido utilizarlo en la sucursal suministrada {obj.CoSucu.Trim()}.");
                    }
                }
                #endregion
            }
            #endregion
        } 
        #endregion

    }
}
