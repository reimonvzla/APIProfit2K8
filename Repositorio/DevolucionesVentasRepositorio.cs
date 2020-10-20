namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class DevolucionesVentasRepositorio : IRepositorio<EncabDevolucionVenta>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        readonly Utilitarios utilitarios = new Utilitarios();
        Clientes cliente;
        EncabFacturaVenta factura;
        Cajas caja;

        #region Find
        public EncabDevolucionVenta Find(int key, string empresaDB)
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

            EncabDevolucionVenta devo = db.DevCli.Select(d => new EncabDevolucionVenta()
            {
                #region Campos
                FactNum = d.FactNum,
                Contrib = d.Contrib,
                Nombre = d.Nombre,
                Rif = d.Rif,
                Nit = d.Nit,
                NumControl = d.NumControl,
                Status = d.Status,
                Comentario = d.Comentario,
                Descrip = d.Descrip,
                Saldo = d.Saldo,
                FecEmis = d.FecEmis,
                FecVenc = d.FecVenc,
                CoCli = d.CoCli,
                CoVen = d.CoVen,
                CoTran = d.CoTran,
                DirEnt = d.DirEnt,
                FormaPag = d.FormaPag,
                TotBruto = d.TotBruto,
                TotNeto = d.TotNeto,
                GlobDesc = d.GlobDesc,
                TotReca = d.TotReca,
                PorcGdesc = d.PorcGdesc,
                PorcReca = d.PorcReca,
                TotalUc = d.TotalUc,
                TotalCp = d.TotalCp,
                TotFlete = d.TotFlete,
                MontoDev = d.MontoDev,
                Totklu = d.Totklu,
                Anulada = d.Anulada,
                Impresa = d.Impresa,
                Iva = d.Iva,
                IvaDev = d.IvaDev,
                Feccom = d.Feccom,
                Numcom = d.Numcom,
                Tasa = d.Tasa,
                Moneda = d.Moneda,
                DisCen = d.DisCen,
                NcNum = d.NcNum,
                Seriales = d.Seriales,
                Tasag = d.Tasag,
                Tasag10 = d.Tasag10,
                Tasag20 = d.Tasag20,
                Campo1 = d.Campo1,
                Campo2 = d.Campo2,
                Campo3 = d.Campo3,
                Campo4 = d.Campo4,
                Campo5 = d.Campo5,
                Campo6 = d.Campo6,
                Campo7 = d.Campo7,
                Campo8 = d.Campo8,
                CoUsIn = d.CoUsIn,
                FeUsIn = d.FeUsIn,
                CoUsMo = d.CoUsMo,
                FeUsMo = d.FeUsMo,
                CoUsEl = d.CoUsEl,
                FeUsEl = d.FeUsEl,
                Revisado = d.Revisado,
                Trasnfe = d.Trasnfe,
                Numcon = d.Numcon,
                CoSucu = d.CoSucu,
                Rowguid = d.Rowguid,
                MonIlc = d.MonIlc,
                Otros1 = d.Otros1,
                Otros2 = d.Otros2,
                Otros3 = d.Otros3,
                NumCob = d.NumCob,
                MovCaj = d.MovCaj,
                MovBan = d.MovBan,
                SaldoNcr = d.SaldoNcr,
                NumTurno = d.NumTurno,
                Aux01 = d.Aux01,
                Aux02 = d.Aux02,
                Salestax = d.Salestax,
                Origen = d.Origen,
                OrigenD = d.OrigenD,
                StaProd = d.StaProd,
                Telefono = d.Telefono
                #endregion

            }).FirstOrDefault(d => d.FactNum == key);

            List<DetaDevolucionVenta> reng = (from i in db.RengDvc
                                              where i.FactNum == key
                                              orderby i.RengNum ascending
                                              select new DetaDevolucionVenta
                                              {
                                                  #region Campos
                                                  FactNum = i.FactNum,
                                                  RengNum = i.RengNum,
                                                  DisCen = i.DisCen,
                                                  TipoDoc = i.TipoDoc,
                                                  RengDoc = i.RengDoc,
                                                  NumDoc = i.NumDoc,
                                                  CoArt = i.CoArt,
                                                  CoAlma = i.CoAlma,
                                                  TotalArt = i.TotalArt,
                                                  StotalArt = i.StotalArt,
                                                  Pendiente = i.Pendiente,
                                                  UniVenta = i.UniVenta,
                                                  PrecVta = i.PrecVta,
                                                  PorcDesc = i.PorcDesc,
                                                  TipoImp = i.TipoImp,
                                                  RengNeto = i.RengNeto,
                                                  CosProUn = i.CosProUn,
                                                  UltCosUn = i.UltCosUn,
                                                  UltCosOm = i.UltCosOm,
                                                  CosProOm = i.CosProOm,
                                                  TotalDev = i.TotalDev,
                                                  MontoDev = i.MontoDev,
                                                  PrecVta2 = i.PrecVta2,
                                                  Anulado = i.Anulado,
                                                  DesArt = i.DesArt,
                                                  Seleccion = i.Seleccion,
                                                  CantImp = i.CantImp,
                                                  Comentario = i.Comentario,
                                                  Rowguid = i.Rowguid,
                                                  TotalUni = i.TotalUni,
                                                  MonIlc = i.MonIlc,
                                                  Otros = i.Otros,
                                                  NroLote = i.NroLote,
                                                  FecLote = i.FecLote,
                                                  Pendiente2 = i.Pendiente2,
                                                  TipoDoc2 = i.TipoDoc2,
                                                  RengDoc2 = i.RengDoc2,
                                                  NumDoc2 = i.NumDoc2,
                                                  TipoPrec = i.TipoPrec,
                                                  CoAlma2 = i.CoAlma2,
                                                  Aux01 = i.Aux01,
                                                  Aux02 = i.Aux02,
                                                  CantProd = i.CantProd,
                                                  ImpProd = i.ImpProd
                                                  #endregion

                                              }).ToList();
            devo.DetaDevolucionVenta = reng;
            return devo;
        }
        #endregion

        #region GetAll
        public IEnumerable<EncabDevolucionVenta> GetAll(string empresaDB)
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

            List<EncabDevolucionVenta> devo = db.DevCli.Select(d => new EncabDevolucionVenta()
            {
                #region Campos
                FactNum = d.FactNum,
                Contrib = d.Contrib,
                Nombre = d.Nombre,
                Rif = d.Rif,
                Nit = d.Nit,
                NumControl = d.NumControl,
                Status = d.Status,
                Comentario = d.Comentario,
                Descrip = d.Descrip,
                Saldo = d.Saldo,
                FecEmis = d.FecEmis,
                FecVenc = d.FecVenc,
                CoCli = d.CoCli,
                CoVen = d.CoVen,
                CoTran = d.CoTran,
                DirEnt = d.DirEnt,
                FormaPag = d.FormaPag,
                TotBruto = d.TotBruto,
                TotNeto = d.TotNeto,
                GlobDesc = d.GlobDesc,
                TotReca = d.TotReca,
                PorcGdesc = d.PorcGdesc,
                PorcReca = d.PorcReca,
                TotalUc = d.TotalUc,
                TotalCp = d.TotalCp,
                TotFlete = d.TotFlete,
                MontoDev = d.MontoDev,
                Totklu = d.Totklu,
                Anulada = d.Anulada,
                Impresa = d.Impresa,
                Iva = d.Iva,
                IvaDev = d.IvaDev,
                Feccom = d.Feccom,
                Numcom = d.Numcom,
                Tasa = d.Tasa,
                Moneda = d.Moneda,
                DisCen = d.DisCen,
                NcNum = d.NcNum,
                Seriales = d.Seriales,
                Tasag = d.Tasag,
                Tasag10 = d.Tasag10,
                Tasag20 = d.Tasag20,
                Campo1 = d.Campo1,
                Campo2 = d.Campo2,
                Campo3 = d.Campo3,
                Campo4 = d.Campo4,
                Campo5 = d.Campo5,
                Campo6 = d.Campo6,
                Campo7 = d.Campo7,
                Campo8 = d.Campo8,
                CoUsIn = d.CoUsIn,
                FeUsIn = d.FeUsIn,
                CoUsMo = d.CoUsMo,
                FeUsMo = d.FeUsMo,
                CoUsEl = d.CoUsEl,
                FeUsEl = d.FeUsEl,
                Revisado = d.Revisado,
                Trasnfe = d.Trasnfe,
                Numcon = d.Numcon,
                CoSucu = d.CoSucu,
                Rowguid = d.Rowguid,
                MonIlc = d.MonIlc,
                Otros1 = d.Otros1,
                Otros2 = d.Otros2,
                Otros3 = d.Otros3,
                NumCob = d.NumCob,
                MovCaj = d.MovCaj,
                MovBan = d.MovBan,
                SaldoNcr = d.SaldoNcr,
                NumTurno = d.NumTurno,
                Aux01 = d.Aux01,
                Aux02 = d.Aux02,
                Salestax = d.Salestax,
                Origen = d.Origen,
                OrigenD = d.OrigenD,
                StaProd = d.StaProd,
                Telefono = d.Telefono
                #endregion

            }).ToList();

            for (int r = 0; r < devo.Count; r++)
            {
                List<DetaDevolucionVenta> reng = (from i in db.RengDvc
                                                  where i.FactNum == devo[r].FactNum
                                                  orderby i.RengNum ascending
                                                  select new DetaDevolucionVenta
                                                  {
                                                      #region Campos
                                                      FactNum = i.FactNum,
                                                      RengNum = i.RengNum,
                                                      DisCen = i.DisCen,
                                                      TipoDoc = i.TipoDoc,
                                                      RengDoc = i.RengDoc,
                                                      NumDoc = i.NumDoc,
                                                      CoArt = i.CoArt,
                                                      CoAlma = i.CoAlma,
                                                      TotalArt = i.TotalArt,
                                                      StotalArt = i.StotalArt,
                                                      Pendiente = i.Pendiente,
                                                      UniVenta = i.UniVenta,
                                                      PrecVta = i.PrecVta,
                                                      PorcDesc = i.PorcDesc,
                                                      TipoImp = i.TipoImp,
                                                      RengNeto = i.RengNeto,
                                                      CosProUn = i.CosProUn,
                                                      UltCosUn = i.UltCosUn,
                                                      UltCosOm = i.UltCosOm,
                                                      CosProOm = i.CosProOm,
                                                      TotalDev = i.TotalDev,
                                                      MontoDev = i.MontoDev,
                                                      PrecVta2 = i.PrecVta2,
                                                      Anulado = i.Anulado,
                                                      DesArt = i.DesArt,
                                                      Seleccion = i.Seleccion,
                                                      CantImp = i.CantImp,
                                                      Comentario = i.Comentario,
                                                      Rowguid = i.Rowguid,
                                                      TotalUni = i.TotalUni,
                                                      MonIlc = i.MonIlc,
                                                      Otros = i.Otros,
                                                      NroLote = i.NroLote,
                                                      FecLote = i.FecLote,
                                                      Pendiente2 = i.Pendiente2,
                                                      TipoDoc2 = i.TipoDoc2,
                                                      RengDoc2 = i.RengDoc2,
                                                      NumDoc2 = i.NumDoc2,
                                                      TipoPrec = i.TipoPrec,
                                                      CoAlma2 = i.CoAlma2,
                                                      Aux01 = i.Aux01,
                                                      Aux02 = i.Aux02,
                                                      CantProd = i.CantProd,
                                                      ImpProd = i.ImpProd
                                                      #endregion

                                                  }).ToList();
                devo[r].DetaDevolucionVenta = reng;
            }
            return devo;
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(EncabDevolucionVenta item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                Utilitarios utilitarios = new Utilitarios();

                #region Validar devolucion
                ValidarDevolucion(item, empresaDB);
                #endregion

                #region Buscar consecutivos
                int numeroDevo = utilitarios.BuscarConsecutivo("DEVO", item.CoSucu, empresaDB);
                int numeroNCR = utilitarios.BuscarConsecutivo("N/CR", item.CoSucu, empresaDB);
                var numeroControl = utilitarios.BuscarNroControl(item.CoSucu, empresaDB);
                #endregion

                if (numeroDevo > 0)
                {
                    #region Nota de credito

                    #region Calcular exento para el DisCen
                    decimal TotalExento = (from exento in item.DetaDevolucionVenta where exento.TipoImp == "6" select exento).Sum(t => t.RengNeto);
                    #endregion

                    #region Construcción de DisCen
                    string DisCen = utilitarios.ArmarDisCen(item.FecEmis, (decimal)item.TotBruto, item.Iva, TotalExento, empresaDB);
                    #endregion

                    #region Creando N/CR
                    Response ncr = new DocumentosVentasRepositorio()
                            .Save(new DocumCc
                            {
                                #region Campos
                                Numcon = numeroControl,
                                CoCli = item.CoCli,
                                Contrib = cliente.Contribu,
                                NroDoc = 0,
                                TipoDoc = "N/CR",
                                Moneda = item.Moneda,
                                CoVen = item.CoVen,
                                FeUsIn = item.FeUsIn,
                                FeUsMo = item.FeUsMo,
                                FeUsEl = item.FeUsEl,
                                CoSucu = item.CoSucu,
                                Tipo = "1",
                                FecEmis = DateTime.Now,
                                FecVenc = DateTime.Now,
                                MontoImp = item.Iva,
                                Observa = $"Devol. Asoc:Fact No.{factura.FactNum}.",
                                MontoBru = (decimal)item.TotBruto,
                                Recargo = string.Empty,
                                MontoNet = (decimal)item.TotNeto,
                                DocOrig = "DEVO",
                                NroOrig = numeroDevo,
                                Tasa = item.Tasa,
                                Saldo = (decimal)item.TotNeto,
                                Salestax = string.Empty,
                                Aut = true,
                                CoUsIn = item.CoUsIn,
                                CoUsMo = item.CoUsMo,
                                CoUsEl = item.CoUsEl,
                                Feccom = DateTime.Now
                                #endregion

                            }, empresaDB);
                    #endregion

                    #endregion

                    #region Cancelacion automatica de la devolución
                    if (ncr.Status == "OK")
                    {
                        #region Guardar cobro
                        Response cobroresult = new CobrosRepositorio()
                            .Save(new EncabCobro
                            {
                                #region Campos cobro
                                CobNum = 0,
                                Recibo = string.Empty,
                                CoCli = item.CoCli,
                                CoVen = item.CoVen,
                                FecCob = DateTime.Now,
                                Feccom = DateTime.Now,
                                Tasa = item.Tasa,
                                Moneda = item.Moneda,
                                CoUsIn = item.CoUsIn,
                                FeUsIn = item.FeUsIn,
                                CoUsMo = item.CoUsMo,
                                FeUsMo = item.FeUsMo,
                                CoUsEl = item.CoUsEl,
                                FeUsEl = item.FeUsEl,
                                CoSucu = item.CoSucu,
                                Descrip = $"Cobro generado por la Devolución Nro. {numeroDevo}",
                                NumDev = numeroDevo,
                                DetaCobro = new List<DetaCobro>
                                {
                                    new DetaCobro
                                    {
                                        #region Renglon factura
		                            CobNum = 0,
                                    RengNum = 1,
                                    TpDocCob = "FACT",
                                    DocNum = factura.FactNum,
                                    Neto = (decimal)factura.TotNeto,
                                    MontCob = (decimal)factura.TotNeto,
                                    Isv = (decimal)factura.Iva,
                                    Moneda = item.Moneda,
                                    Tasa = item.Tasa,
                                    FecEmis = DateTime.Now,
                                    FecVenc = DateTime.Now 
	                                #endregion
                                    },
                                    new DetaCobro
                                    {
                                        #region Renglon nota de crédito
		                            CobNum = 0,
                                    RengNum = 2,
                                    TpDocCob = "N/CR",
                                    DocNum = numeroNCR,
                                    Neto = (decimal)item.TotNeto,
                                    MontCob = (decimal)item.TotNeto,
                                    Isv = (decimal)item.Iva,
                                    Moneda = item.Moneda,
                                    Tasa = item.Tasa,
                                    FecEmis = DateTime.Now,
                                    FecVenc = DateTime.Now 
	                                #endregion
                                    }
                                },
                                FormaPagoCobro = new List<FormaPagoCobro>
                                {
                                    new FormaPagoCobro
                                    {
                                        #region Campos
		                            CobNum=0,
                                    RengNum=1,
                                    TipCob="EFEC",
                                    Movi=0,
                                    Moneda=item.Moneda,
                                    CodCaja =caja.CodCaja,
                                    DesCaja=caja.Descrip,
                                    FecCheq=DateTime.Now,
                                    Banco="DEVO" // Fuck you...
	                                #endregion
                                    }
                                }
                                #endregion

                            }, empresaDB);
                        #endregion

                        #region Actualizar saldo factura y documento (FACT)
                        if (cobroresult.Status == "OK")
                        {
                            item.NumCob = Convert.ToInt32(cobroresult.FacturaID); //;-)

                            factura.CoUsMo = item.CoUsMo;
                            factura.FeUsMo = item.FeUsMo;
                            factura.Saldo -= (decimal)item.TotNeto;

                            #region Detalle de factura y stock
                            foreach (var iRengDev in item.DetaDevolucionVenta)
                            {
                                #region Monto devuelto en rengfac
                                factura.DetaFacturaVenta.FirstOrDefault(d => d.FactNum == iRengDev.NumDoc && d.RengNum == iRengDev.RengDoc).TotalDev += iRengDev.TotalArt;
                                #endregion

                                #region actualización de stock
                                utilitarios.ActualizarStockArticuloAlmacen(iRengDev.CoArt, iRengDev.CoAlma, iRengDev.TotalArt, true, empresaDB);
                                #endregion
                            }
                            #endregion

                            Response factresult = new FacturasVentasRepositorio().Update(factura, empresaDB);
                        }
                        else 
                        {
                            throw new ArgumentException(cobroresult.Message);
                        }
                        #endregion
                    }
                    else 
                    {
                        throw new ArgumentException(ncr.Message);
                    }
                    #endregion

                    #region Devolucion
                    List<RengDvc> RengDvcs = new List<RengDvc>();

                    db.Entry(new DevCli
                    {
                        #region Campos
                        FactNum = numeroDevo,
                        Contrib = item.Contrib,
                        Nombre = item.Nombre,
                        Rif = item.Rif,
                        Nit = item.Nit,
                        NumControl = item.NumControl,
                        Status = item.Status,
                        Comentario = "<Forma Pago: Efectivo>",
                        Descrip = item.Descrip,
                        Saldo = item.Saldo,
                        FecEmis = item.FecEmis,
                        FecVenc = item.FecVenc,
                        CoCli = item.CoCli,
                        CoVen = item.CoVen,
                        CoTran = item.CoTran,
                        DirEnt = item.DirEnt,
                        FormaPag = item.FormaPag,
                        TotBruto = item.TotBruto,
                        TotNeto = item.TotNeto,
                        GlobDesc = item.GlobDesc,
                        TotReca = item.TotReca,
                        PorcGdesc = item.PorcGdesc,
                        PorcReca = item.PorcReca,
                        TotalUc = item.TotalUc,
                        TotalCp = item.TotalCp,
                        TotFlete = item.TotFlete,
                        MontoDev = item.MontoDev,
                        Totklu = item.Totklu,
                        Anulada = item.Anulada,
                        Impresa = item.Impresa,
                        Iva = item.Iva,
                        IvaDev = item.IvaDev,
                        Feccom = item.Feccom,
                        Numcom = item.Numcom,
                        Tasa = item.Tasa,
                        Moneda = item.Moneda,
                        DisCen = DisCen,
                        NcNum = numeroNCR, // ;-)
                        Seriales = item.Seriales,
                        Tasag = item.Tasag,
                        Tasag10 = item.Tasag10,
                        Tasag20 = item.Tasag20,
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
                        Numcon = numeroControl,
                        CoSucu = item.CoSucu,
                        Rowguid = item.Rowguid,
                        MonIlc = item.MonIlc,
                        Otros1 = item.Otros1,
                        Otros2 = item.Otros2,
                        Otros3 = item.Otros3,
                        NumCob = item.NumCob, //;-)
                        MovCaj = item.MovCaj,
                        MovBan = item.MovBan,
                        SaldoNcr = item.SaldoNcr,
                        NumTurno = item.NumTurno,
                        Aux01 = item.Aux01,
                        Aux02 = item.Aux02,
                        Salestax = item.Salestax,
                        Origen = item.Origen,
                        OrigenD = item.OrigenD,
                        StaProd = item.StaProd,
                        Telefono = item.Telefono 
                        #endregion
                    
                    }).State = EntityState.Added;

                    foreach (var i in item.DetaDevolucionVenta)
                    {
                        RengDvc reng = new RengDvc 
                        {
                            #region Campos
                            FactNum = numeroDevo,
                            RengNum = i.RengNum,
                            TipoDoc = i.TipoDoc,
                            RengDoc = i.RengDoc,
                            NumDoc = i.NumDoc,
                            CoArt = i.CoArt,
                            CoAlma = i.CoAlma,
                            TotalArt = i.TotalArt,
                            StotalArt = i.StotalArt,
                            Pendiente = i.Pendiente,
                            UniVenta = i.UniVenta,
                            PrecVta = i.PrecVta,
                            PorcDesc = i.PorcDesc,
                            TipoImp = i.TipoImp,
                            RengNeto = i.RengNeto,
                            CosProUn = i.CosProUn,
                            UltCosUn = i.UltCosUn,
                            UltCosOm = i.UltCosOm,
                            CosProOm = i.CosProOm,
                            PrecVta2 = i.PrecVta2,
                            DesArt = i.DesArt,
                            Comentario = i.Comentario,
                            TotalUni = i.TotalUni,
                            MonIlc = i.MonIlc,
                            Otros = i.Otros,
                            NroLote = i.NroLote,
                            FecLote = i.FecLote,
                            TipoPrec = i.TipoPrec,
                            CoAlma2 = i.CoAlma2,
                            Aux01 = i.Aux01,
                            Aux02 = i.Aux02
                            #endregion

                        };
                        db.Entry(reng).State = EntityState.Added;
                    }
                    db.SaveChanges();
                    #endregion

                    #region Actualización de consecutivos
                    utilitarios.ActualizarConsecutivo(numeroDevo, "DEVO", item.CoSucu, empresaDB);
                    utilitarios.ActualizarConsecutivo(numeroNCR, "N/CR", item.CoSucu, empresaDB);
                    #endregion

                }
                else
                {
                    throw new ArgumentException("No se encontró el correlativo configurado para 'DEVO'.");
                }

                return new Response { Status = "OK", Message = "Transacción realizada con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Update
        public Response Update(EncabDevolucionVenta item, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Validar devolucion
        private void ValidarDevolucion(EncabDevolucionVenta obj, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

            #region Verificar caja ppal para el cobro
            caja = db.Cajas.FirstOrDefault(c => c.Cajapri == true);
            if (caja == null) throw new ArgumentException("No existe una caja principal para la cancelación del cobro. Llame a su consultor profit.");
            #endregion

            #region Verificar cliente
            cliente = new ClientesRepositorio().GetCliente(obj.CoCli, empresaDB);
            if (cliente == null)
            {
                throw new ArgumentException($"El cliente {obj.CoCli.Trim()} indicado para la devolución no existe.");
            }
            else
            {
                if (cliente.Inactivo)
                {
                    throw new ArgumentException($"El cliente {obj.CoCli.Trim()} indicado para la devolución se encuentra inactivo.");
                }
            }
            #endregion

            #region Verificar vendedor
            Vendedor vendor = new VendedoresRepositorio().Find(obj.CoVen, empresaDB);
            if (vendor != null)
            {
                if (!vendor.FunVen)
                {
                    throw new ArgumentException($"Vendedor {obj.CoVen} indicado no tiene función de 'vendedor'.");
                }
                if (!vendor.FunCob)
                {
                    throw new ArgumentException($"Vendedor {obj.CoVen} indicado no tiene función de 'cobrador'.");
                }
            }
            else
            {
                throw new ArgumentException($"El vendedor {obj.CoVen} suministrado no existe.");
            }
            #endregion

            #region Verificar transporte
            Transpor transporte = db.Transpor.FirstOrDefault(t => t.CoTran == obj.CoTran);
            if (transporte == null)
            {
                throw new ArgumentException($"El transporte {obj.CoTran} suministrado no existe.");
            }
            #endregion

            #region Verificar condicion de pago
            Condicio condicion = db.Condicio.FirstOrDefault(c => c.CoCond == obj.FormaPag);
            if (condicion == null)
            {
                throw new ArgumentException($"La condición de pago {obj.FormaPag} suministrado no existe.");
            }
            #endregion

            #region Verificar moneda
            utilitarios.GetMoneda(obj.Moneda, empresaDB);
            #endregion

            #region Verificar sucursal
            utilitarios.GetSucursal(obj.CoSucu, empresaDB);
            #endregion

            #region Verificar datos en renglones de factura
            foreach (var iRengFac in obj.DetaDevolucionVenta)
            {
                #region Verificar factura
                factura = new FacturasVentasRepositorio().Find(iRengFac.NumDoc, empresaDB);
                if (factura == null) throw new ArgumentException($"La factura {iRengFac.NumDoc} indicada en el renglón {iRengFac.RengNum} en la devolución de cliente no existe.");
                if (factura.Anulada) throw new ArgumentException($"La factura {iRengFac.NumDoc} indicada en el renglón {iRengFac.RengNum} en la devolución de cliente se encuentra anulada.");
                if (factura.Saldo == 0) throw new ArgumentException($"La factura {iRengFac.NumDoc} indicada en el renglón {iRengFac.RengNum} se encuentra procesada [Saldo=0.00].");
                if (factura.Saldo < iRengFac.RengNeto) throw new ArgumentException($"La factura {iRengFac.NumDoc} tiene un saldo menor al monto indicado en el renglón {iRengFac.RengNum}.");
                if (factura.DetaFacturaVenta.FirstOrDefault(ra => ra.CoArt.Trim() == iRengFac.CoArt.Trim()) == null) throw new ArgumentException($"El artículo {iRengFac.CoArt.Trim()} indicado en el renglón {iRengFac.RengNum} no se encontró en la factura.");
                #endregion

                #region Verificar articulo
                Art articulo = new ArticulosRepositorio().Find(iRengFac.CoArt, empresaDB);
                if (articulo == null)
                {
                    throw new ArgumentException($"El artículo {iRengFac.CoArt.Trim()} suministrado en el renglón {iRengFac.RengNum} no existe.");
                }
                #endregion

                #region Verificar almacen
                SubAlma almacen = db.SubAlma.FirstOrDefault(a => a.CoSub == iRengFac.CoAlma);
                if (almacen == null)
                {
                    throw new ArgumentException($"El almacén {iRengFac.CoAlma.Trim()} suministrado en el renglón {iRengFac.RengNum} no existe.");
                }
                else
                {
                    if (almacen.CoAlma.Trim() != obj.CoSucu.Trim())
                    {
                        throw new ArgumentException($"El almacén {iRengFac.CoAlma.Trim()} suministrado en el renglón {iRengFac.RengNum} no está permitido utilizarlo en la sucursal suministrada {obj.CoSucu.Trim()}.");
                    }
                    if (almacen.Noventa)
                    {
                        throw new ArgumentException($"El almacén {iRengFac.CoAlma.Trim()} suministrado en el renglón {iRengFac.RengNum} no está permitido utilizarlo en el módulo de facturas.");
                    }
                }
                #endregion

                #region Verificar unidad primaria
                Unidades unidad = db.Unidades.FirstOrDefault(u => u.CoUni == iRengFac.UniVenta);
                if (unidad == null)
                {
                    throw new ArgumentException($"La unidad de venta {iRengFac.UniVenta.Trim()} suministrada en el renglón {iRengFac.RengNum} no existe.");
                }
                #endregion

            }
            #endregion

        } 
        #endregion
    }
}
