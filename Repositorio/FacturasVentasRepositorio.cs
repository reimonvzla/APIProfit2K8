namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class FacturasVentasRepositorio : IRepositorio<EncabFacturaVenta>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        readonly Utilitarios utilitarios = new Utilitarios();
        Clientes cliente;

        #region Find
        public EncabFacturaVenta Find(int key, string empresaDB)
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
            EncabFacturaVenta fact = db.Factura.Select(f => new EncabFacturaVenta()
            {
                #region Campos encabezado
                FactNum = f.FactNum,
                Contrib = f.Contrib,
                Nombre = f.Nombre,
                Rif = f.Rif,
                Nit = f.Nit,
                NumControl = f.NumControl,
                Status = f.Status,
                Comentario = f.Comentario,
                Descrip = f.Descrip,
                Saldo = f.Saldo,
                FecEmis = f.FecEmis,
                FecVenc = f.FecVenc,
                CoCli = f.CoCli,
                CoVen = f.CoVen,
                CoTran = f.CoTran,
                DirEnt = f.DirEnt,
                FormaPag = f.FormaPag,
                TotBruto = f.TotBruto,
                TotNeto = f.TotNeto,
                GlobDesc = f.GlobDesc,
                TotReca = f.TotReca,
                PorcGdesc = f.PorcReca,
                PorcReca = f.PorcReca,
                TotalUc = f.TotalUc,
                TotalCp = f.TotalCp,
                TotFlete = f.TotFlete,
                MontoDev = f.MontoDev,
                Totklu = f.Totklu,
                Anulada = f.Anulada,
                Impresa = f.Impresa,
                Iva = f.Iva,
                IvaDev = f.IvaDev,
                Feccom = f.Feccom,
                Numcom = f.Numcom,
                Tasa = f.Tasa,
                Moneda = f.Moneda,
                DisCen = f.DisCen,
                Vuelto = f.Vuelto,
                Seriales = f.Seriales,
                Tasag = f.Tasag,
                Tasag10 = f.Tasag10,
                Tasag20 = f.Tasag20,
                Campo1 = f.Campo1,
                Campo2 = f.Campo2,
                Campo3 = f.Campo3,
                Campo4 = f.Campo4,
                Campo5 = f.Campo5,
                Campo6 = f.Campo6,
                Campo7 = f.Campo7,
                Campo8 = f.Campo8,
                CoUsIn = f.CoUsIn,
                FeUsIn = f.FeUsIn,
                CoUsMo = f.CoUsMo,
                FeUsMo = f.FeUsMo,
                CoUsEl = f.CoUsEl,
                FeUsEl = f.FeUsEl,
                Revisado = f.Revisado,
                Trasnfe = f.Trasnfe,
                Numcon = f.Numcon,
                CoSucu = f.CoSucu,
                Rowguid = f.Rowguid,
                MonIlc = f.MonIlc,
                Otros1 = f.Otros1,
                Otros2 = f.Otros2,
                Otros3 = f.Otros3,
                NumTurno = f.NumTurno,
                Aux01 = f.Aux01,
                Aux02 = f.Aux02,
                Id = f.Id,
                Salestax = f.Salestax,
                Origen = f.Origen,
                OrigenD = f.OrigenD,
                StaProd = f.StaProd,
                FecReg = f.FecReg,
                Impfis = f.Impfis,
                Impfisfac = f.Impfisfac,
                ImpNroZ = f.ImpNroZ,
                VenTer = f.VenTer,
                Ptovta = f.Ptovta,
                Telefono = f.Telefono,
                DetaFacturaVenta = new List<DetaFacturaVenta>()
                #endregion

            }).FirstOrDefault(fa => fa.FactNum == key);

            List<DetaFacturaVenta> reng = (from i in db.RengFac
                                           where i.FactNum == fact.FactNum
                                           orderby i.RengNum ascending
                                           select new DetaFacturaVenta()
                                           {
                                               #region Campos Detalle
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
                                               Isv = i.Isv,
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

            fact.DetaFacturaVenta = reng;

            #region Comentado
            //foreach (var d in reng)
            //{
            //    DetaFacturaVenta row = new DetaFacturaVenta
            //    {
            //        #region Campos detalle
            //        FactNum = d.FactNum,
            //        RengNum = d.RengNum,
            //        DisCen = d.DisCen,
            //        TipoDoc = d.TipoDoc,
            //        RengDoc = d.RengDoc,
            //        NumDoc = d.NumDoc,
            //        CoArt = d.CoArt,
            //        CoAlma = d.CoAlma,
            //        TotalArt = d.TotalArt,
            //        StotalArt = d.StotalArt,
            //        Pendiente = d.Pendiente,
            //        UniVenta = d.UniVenta,
            //        PrecVta = d.PrecVta,
            //        PorcDesc = d.PorcDesc,
            //        TipoImp = d.TipoImp,
            //        Isv = d.Isv,
            //        RengNeto = d.RengNeto,
            //        CosProUn = d.CosProUn,
            //        UltCosUn = d.UltCosUn,
            //        UltCosOm = d.UltCosOm,
            //        CosProOm = d.CosProOm,
            //        TotalDev = d.TotalDev,
            //        MontoDev = d.MontoDev,
            //        PrecVta2 = d.PrecVta2,
            //        Anulado = d.Anulado,
            //        DesArt = d.DesArt,
            //        Seleccion = d.Seleccion,
            //        CantImp = d.CantImp,
            //        Comentario = d.Comentario,
            //        Rowguid = d.Rowguid,
            //        TotalUni = d.TotalUni,
            //        MonIlc = d.MonIlc,
            //        Otros = d.Otros,
            //        NroLote = d.NroLote,
            //        FecLote = d.FecLote,
            //        Pendiente2 = d.Pendiente2,
            //        TipoDoc2 = d.TipoDoc2,
            //        RengDoc2 = d.RengDoc2,
            //        NumDoc2 = d.NumDoc2,
            //        TipoPrec = d.TipoPrec,
            //        CoAlma2 = d.CoAlma2,
            //        Aux01 = d.Aux01,
            //        Aux02 = d.Aux02,
            //        CantProd = d.CantProd,
            //        ImpProd = d.ImpProd
            //        #endregion
            //    };

            //    fact.DetaFacturaVenta.Add(row);
            //} 
            #endregion

            return fact;
        }
        #endregion

        #region GetAll
        public IEnumerable<EncabFacturaVenta> GetAll(string empresaDB)
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
            List<EncabFacturaVenta> fact = db.Factura.Select(f => new EncabFacturaVenta()
            {
                #region Campos encabezado
                FactNum = f.FactNum,
                Contrib = f.Contrib,
                Nombre = f.Nombre,
                Rif = f.Rif,
                Nit = f.Nit,
                NumControl = f.NumControl,
                Status = f.Status,
                Comentario = f.Comentario,
                Descrip = f.Descrip,
                Saldo = f.Saldo,
                FecEmis = f.FecEmis,
                FecVenc = f.FecVenc,
                CoCli = f.CoCli,
                CoVen = f.CoVen,
                CoTran = f.CoTran,
                DirEnt = f.DirEnt,
                FormaPag = f.FormaPag,
                TotBruto = f.TotBruto,
                TotNeto = f.TotNeto,
                GlobDesc = f.GlobDesc,
                TotReca = f.TotReca,
                PorcGdesc = f.PorcReca,
                PorcReca = f.PorcReca,
                TotalUc = f.TotalUc,
                TotalCp = f.TotalCp,
                TotFlete = f.TotFlete,
                MontoDev = f.MontoDev,
                Totklu = f.Totklu,
                Anulada = f.Anulada,
                Impresa = f.Impresa,
                Iva = f.Iva,
                IvaDev = f.IvaDev,
                Feccom = f.Feccom,
                Numcom = f.Numcom,
                Tasa = f.Tasa,
                Moneda = f.Moneda,
                DisCen = f.DisCen,
                Vuelto = f.Vuelto,
                Seriales = f.Seriales,
                Tasag = f.Tasag,
                Tasag10 = f.Tasag10,
                Tasag20 = f.Tasag20,
                Campo1 = f.Campo1,
                Campo2 = f.Campo2,
                Campo3 = f.Campo3,
                Campo4 = f.Campo4,
                Campo5 = f.Campo5,
                Campo6 = f.Campo6,
                Campo7 = f.Campo7,
                Campo8 = f.Campo8,
                CoUsIn = f.CoUsIn,
                FeUsIn = f.FeUsIn,
                CoUsMo = f.CoUsMo,
                FeUsMo = f.FeUsMo,
                CoUsEl = f.CoUsEl,
                FeUsEl = f.FeUsEl,
                Revisado = f.Revisado,
                Trasnfe = f.Trasnfe,
                Numcon = f.Numcon,
                CoSucu = f.CoSucu,
                Rowguid = f.Rowguid,
                MonIlc = f.MonIlc,
                Otros1 = f.Otros1,
                Otros2 = f.Otros2,
                Otros3 = f.Otros3,
                NumTurno = f.NumTurno,
                Aux01 = f.Aux01,
                Aux02 = f.Aux02,
                Id = f.Id,
                Salestax = f.Salestax,
                Origen = f.Origen,
                OrigenD = f.OrigenD,
                StaProd = f.StaProd,
                FecReg = f.FecReg,
                Impfis = f.Impfis,
                Impfisfac = f.Impfisfac,
                ImpNroZ = f.ImpNroZ,
                VenTer = f.VenTer,
                Ptovta = f.Ptovta,
                Telefono = f.Telefono,
                DetaFacturaVenta = new List<DetaFacturaVenta>()
                #endregion

            }).ToList();
            for (int r = 0; r < fact.Count; r++)
            {
                List<DetaFacturaVenta> reng = (from i in db.RengFac
                                               where i.FactNum == fact[r].FactNum
                                               select new DetaFacturaVenta()
                                               {
                                                   #region Campos Detalle
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
                                                   Isv = i.Isv,
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
                foreach (var d in reng)
                {
                    DetaFacturaVenta row = new DetaFacturaVenta
                    {
                        #region Campos detalle
                        FactNum = d.FactNum,
                        RengNum = d.RengNum,
                        DisCen = d.DisCen,
                        TipoDoc = d.TipoDoc,
                        RengDoc = d.RengDoc,
                        NumDoc = d.NumDoc,
                        CoArt = d.CoArt,
                        CoAlma = d.CoAlma,
                        TotalArt = d.TotalArt,
                        StotalArt = d.StotalArt,
                        Pendiente = d.Pendiente,
                        UniVenta = d.UniVenta,
                        PrecVta = d.PrecVta,
                        PorcDesc = d.PorcDesc,
                        TipoImp = d.TipoImp,
                        Isv = d.Isv,
                        RengNeto = d.RengNeto,
                        CosProUn = d.CosProUn,
                        UltCosUn = d.UltCosUn,
                        UltCosOm = d.UltCosOm,
                        CosProOm = d.CosProOm,
                        TotalDev = d.TotalDev,
                        MontoDev = d.MontoDev,
                        PrecVta2 = d.PrecVta2,
                        Anulado = d.Anulado,
                        DesArt = d.DesArt,
                        Seleccion = d.Seleccion,
                        CantImp = d.CantImp,
                        Comentario = d.Comentario,
                        Rowguid = d.Rowguid,
                        TotalUni = d.TotalUni,
                        MonIlc = d.MonIlc,
                        Otros = d.Otros,
                        NroLote = d.NroLote,
                        FecLote = d.FecLote,
                        Pendiente2 = d.Pendiente2,
                        TipoDoc2 = d.TipoDoc2,
                        RengDoc2 = d.RengDoc2,
                        NumDoc2 = d.NumDoc2,
                        TipoPrec = d.TipoPrec,
                        CoAlma2 = d.CoAlma2,
                        Aux01 = d.Aux01,
                        Aux02 = d.Aux02,
                        CantProd = d.CantProd,
                        ImpProd = d.ImpProd
                        #endregion
                    };

                    fact[r].DetaFacturaVenta.Add(row);
                }
            }
            return fact;
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(EncabFacturaVenta item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                #region Validar factura
                ValidarFactura(item, empresaDB); 
                #endregion

                #region Buscar consecutivo
                var numeroFactura = utilitarios.BuscarConsecutivo("FACT", item.CoSucu, empresaDB);
                var numeroControl = utilitarios.BuscarNroControl(item.CoSucu, empresaDB);
                #endregion

                if (numeroFactura > 0)
                {

                    #region Calcular exento para el DisCen
                    decimal TotalExento = utilitarios.TotalExento(item.DetaFacturaVenta, empresaDB); 
                    #endregion

                    #region Construcción de DisCen
                    string DisCen = utilitarios.ArmarDisCen(item.FecEmis, (decimal)item.TotBruto, item.Iva, TotalExento, empresaDB);
                    #endregion

                    #region Encabezado factura
                    Factura factura = new Factura
                    {
                        #region Campos encabezado
                        FactNum = numeroFactura,
                        Contrib = item.Contrib,
                        Nombre = item.Nombre,
                        Rif = item.Rif,
                        Nit = item.Nit,
                        NumControl = item.NumControl,
                        Status = item.Status,
                        Comentario = item.Comentario,
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
                        PorcGdesc = item.PorcReca,
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
                        Vuelto = item.Vuelto,
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
                        NumTurno = item.NumTurno,
                        Aux01 = item.Aux01,
                        Aux02 = item.Aux02,
                        Id = item.Id,
                        Salestax = item.Salestax,
                        Origen = item.Origen,
                        OrigenD = item.OrigenD,
                        StaProd = item.StaProd,
                        FecReg = item.FecReg,
                        Impfis = item.Impfis,
                        Impfisfac = item.Impfisfac,
                        ImpNroZ = item.ImpNroZ,
                        VenTer = item.VenTer,
                        Ptovta = item.Ptovta,
                        Telefono = item.Telefono
                        #endregion
                    };

                    db.Factura.Add(factura);
                    db.SaveChanges();
                    #endregion

                    #region Renglones factura
                    List<RengFac> Renglones = new List<RengFac>();

                    foreach (var d in item.DetaFacturaVenta)
                    {
                        RengFac reng_fac = new RengFac
                        {
                            #region Detalle de reng_fac
                            FactNum = numeroFactura,
                            RengNum = d.RengNum,
                            DisCen = d.DisCen,
                            TipoDoc = d.TipoDoc,
                            RengDoc = d.RengDoc,
                            NumDoc = d.NumDoc,
                            CoArt = d.CoArt,
                            CoAlma = d.CoAlma,
                            TotalArt = d.TotalArt,
                            StotalArt = d.StotalArt,
                            Pendiente = d.Pendiente,
                            UniVenta = d.UniVenta,
                            PrecVta = d.PrecVta,
                            PorcDesc = d.PorcDesc,
                            TipoImp = d.TipoImp,
                            Isv = d.Isv,
                            RengNeto = d.RengNeto,
                            CosProUn = d.CosProUn,
                            UltCosUn = d.UltCosUn,
                            UltCosOm = d.UltCosOm,
                            CosProOm = d.CosProOm,
                            TotalDev = d.TotalDev,
                            MontoDev = d.MontoDev,
                            PrecVta2 = d.PrecVta2,
                            Anulado = d.Anulado,
                            DesArt = d.DesArt,
                            Seleccion = d.Seleccion,
                            CantImp = d.CantImp,
                            Comentario = d.Comentario,
                            Rowguid = d.Rowguid,
                            TotalUni = d.TotalUni,
                            MonIlc = d.MonIlc,
                            Otros = d.Otros,
                            NroLote = d.NroLote,
                            FecLote = d.FecLote,
                            Pendiente2 = d.Pendiente2,
                            TipoDoc2 = d.TipoDoc2,
                            RengDoc2 = d.RengDoc2,
                            NumDoc2 = d.NumDoc2,
                            TipoPrec = d.TipoPrec,
                            CoAlma2 = d.CoAlma2,
                            Aux01 = d.Aux01,
                            Aux02 = d.Aux02,
                            CantProd = d.CantProd,
                            ImpProd = d.ImpProd 
                            #endregion
                        };
                        Renglones.Add(reng_fac);
                    }
                    foreach (var i in Renglones)
                    {
                        #region Actualizacion de stock
                        utilitarios.ActualizarStockArticuloAlmacen(i.CoArt, i.CoAlma, i.TotalArt, false, empresaDB); 
                        #endregion
                        
                        db.Entry(i).State = EntityState.Added;
                    }
                    db.SaveChanges();

                    #endregion

                    #region Documento de venta
                    DocumCc documento = new DocumCc
                    {
                        TipoDoc = "FACT",
                        NroDoc = numeroFactura,
                        Aut = true,
                        CoCli = item.CoCli,
                        Contrib = item.Contrib,
                        FecEmis = item.FecEmis,
                        FecVenc = item.FecVenc,
                        Observa = item.Descrip,
                        CoVen = item.CoVen,
                        Tipo = "1",
                        Tasa = item.Tasa,
                        Moneda = item.Moneda,
                        MontoImp = item.Iva,
                        MontoBru = (decimal)item.TotBruto,
                        MontoNet = (decimal)item.TotNeto,
                        Saldo = item.Saldo,
                        Feccom = item.Feccom,
                        DisCen = DisCen,
                        CoUsIn = item.CoUsIn,
                        FeUsIn = item.FeUsIn,
                        Numcon = numeroControl,
                        CoSucu = item.CoSucu
                    };
                    //db.DocumCc.Add(documento);
                    db.Entry(documento).State = EntityState.Added;
                    db.SaveChanges();
                    #endregion

                    #region Actualizar consecutivo
                    utilitarios.ActualizarConsecutivo(numeroFactura, "FACT", item.CoSucu, empresaDB);
                    #endregion

                    #region Actualizar nro control
                    utilitarios.ActualizarNroControl(numeroControl, item.CoSucu, empresaDB);
                    #endregion

                    return new Response { Status = "OK", Message = "Transacción realizada con éxito.", FacturaID = numeroFactura.ToString(), ControlID = numeroControl };
                }
                else
                {
                    throw new ArgumentException("No se encontró el correlativo configurado para 'FACT'.");
                }

            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Validar factura
        private void ValidarFactura(EncabFacturaVenta obj,string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

            #region Verificar cliente
            cliente = new ClientesRepositorio().GetCliente(obj.CoCli, empresaDB);
            if (cliente == null)
            {
                throw new ArgumentException($"El cliente {obj.CoCli.Trim()} indicado para la factura no existe.");
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
            foreach (var iRengFac in obj.DetaFacturaVenta)
            {
                #region Verificar articulo
                Art articulo = db.Art.FirstOrDefault(a => a.CoArt == iRengFac.CoArt);
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

        #region Update
        public Response Update(EncabFacturaVenta item, string empresaDB)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}