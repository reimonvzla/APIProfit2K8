namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class CobrosRepositorio : IRepositorio<EncabCobro>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        Clientes cliente;

        #region Find
        public EncabCobro Find(int key, string empresaDB)
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
            EncabCobro cob = db.Cobros.Select(cb => new EncabCobro()
            {
                #region Cobros
                CobNum = cb.CobNum,
                Recibo = cb.Recibo,
                CoCli = cb.CoCli,
                CoVen = cb.CoVen,
                FecCob = cb.FecCob,
                Anulado = cb.Anulado,
                Monto = cb.Monto,
                Dppago = cb.Dppago,
                MontNcr = cb.MontNcr,
                Ncr = cb.Ncr,
                TcomiPorc = cb.TcomiPorc,
                TcomiLine = cb.TcomiLine,
                TcomiArt = cb.TcomiArt,
                TcomiConc = cb.TcomiConc,
                Feccom = cb.Feccom,
                Tasa = cb.Tasa,
                Moneda = cb.Moneda,
                Numcom = cb.Numcom,
                DisCen = cb.DisCen,
                Campo1 = cb.Campo1,
                Campo2 = cb.Campo2,
                Campo3 = cb.Campo3,
                Campo4 = cb.Campo4,
                Campo5 = cb.Campo5,
                Campo6 = cb.Campo6,
                Campo7 = cb.Campo7,
                Campo8 = cb.Campo8,
                CoUsIn = cb.CoUsIn,
                FeUsIn = cb.FeUsIn,
                CoUsMo = cb.CoUsMo,
                FeUsMo = cb.FeUsMo,
                CoUsEl = cb.CoUsEl,
                FeUsEl = cb.FeUsEl,
                Recargo = cb.Recargo,
                AdelNum = cb.AdelNum,
                Revisado = cb.Revisado,
                Trasnfe = cb.Trasnfe,
                CoSucu = cb.CoSucu,
                Rowguid = cb.Rowguid,
                Descrip = cb.Descrip,
                NumDev = cb.NumDev,
                Devdinero = cb.Devdinero,
                NumTurno = cb.NumTurno,
                Aux01 = cb.Aux01,
                Aux02 = cb.Aux02,
                Origen = cb.Origen,
                OrigenD = cb.OrigenD,
                DetaCobro = new List<DetaCobro>(),
                FormaPagoCobro = new List<FormaPagoCobro>()
                #endregion

            }).FirstOrDefault(c => c.CobNum == key);

            #region Renglones de cobro
            List<DetaCobro> rengCob = (from i in db.RengCob
                                       where i.CobNum == cob.CobNum
                                       orderby i.RengNum ascending
                                       select new DetaCobro
                                       {
                                           #region RengCob
                                           CobNum = i.CobNum,
                                           RengNum = i.RengNum,
                                           TpDocCob = i.TpDocCob,
                                           DocNum = i.DocNum,
                                           Neto = i.Neto,
                                           NetoTmp = i.NetoTmp,
                                           Dppago = i.Dppago,
                                           DppagoTmp = i.DppagoTmp,
                                           RengNcr = i.RengNcr,
                                           CoVen = i.CoVen,
                                           Comis1 = i.Comis1,
                                           Comis2 = i.Comis2,
                                           Comis3 = i.Comis3,
                                           Comis4 = i.Comis4,
                                           SignAjuC = i.SignAjuC,
                                           PorcAjuC = i.PorcAjuC,
                                           PorCob = i.PorCob,
                                           ComiCob = i.ComiCob,
                                           MontCob = i.MontCob,
                                           SinoPago = i.SinoPago,
                                           SinoReten = i.SinoReten,
                                           MontoDppago = i.MontoDppago,
                                           MontoReten = i.MontoReten,
                                           ImpPago = i.ImpPago,
                                           MontoObj = i.MontoObj,
                                           Isv = i.Isv,
                                           NroFact = i.NroFact,
                                           Moneda = i.Moneda,
                                           Tasa = i.Tasa,
                                           Numcon = i.Numcon,
                                           Sustraen = i.Sustraen,
                                           Rowguid = i.Rowguid,
                                           CoIslr = i.CoIslr,
                                           FecEmis = i.FecEmis,
                                           FecVenc = i.FecVenc,
                                           Comis5 = i.Comis5,
                                           Comis6 = i.Comis6,
                                           FactIva = i.FactIva,
                                           RetIva = i.RetIva,
                                           PorcRetn = i.PorcRetn,
                                           PorcDesc = i.PorcDesc,
                                           Aux01 = i.Aux01,
                                           Aux02 = i.Aux02,
                                           ProvTer = i.ProvTer,
                                           RengTer = i.RengTer,
                                           FecCom = i.FecCom,
                                           #endregion

                                       }).ToList();
            #endregion

            #region Mov Caja
            List<MovCaj> movCaja = (from i in db.MovCaj
                                    where i.CobPag == cob.CobNum && i.Origen == "COB"
                                    orderby i.RengNum ascending
                                    select new MovCaj
                                    {
                                        #region Campos MovCaj
                                        MovNum = i.MovNum,
                                        Codigo = i.Codigo,
                                        DepNum = i.DepNum,
                                        RengNum = i.RengNum,
                                        MovAfec = i.MovAfec,
                                        MonDep = i.MonDep,
                                        Origen = i.Origen,
                                        TipoOp = i.TipoOp,
                                        FormaPag = i.FormaPag,
                                        Fecha = i.Fecha,
                                        DocNum = i.DocNum,
                                        Descrip = i.Descrip,
                                        MontoD = i.MontoD,
                                        MontoH = i.MontoH,
                                        CtaEgre = i.CtaEgre,
                                        CobPag = i.CobPag,
                                        OriDep = i.OriDep,
                                        DepCon = i.DepCon,
                                        BancTarj = i.BancTarj,
                                        CodIngben = i.CodIngben,
                                        FechaChe = i.FechaChe,
                                        Feccom = i.Feccom,
                                        Numcom = i.Numcom,
                                        DisCen = i.DisCen,
                                        Moneda = i.Moneda,
                                        Tasa = i.Tasa,
                                        CoUsIn = i.CoUsIn,
                                        FeUsIn = i.FeUsIn,
                                        CoUsMo = i.CoUsMo,
                                        FeUsMo = i.FeUsMo,
                                        CoUsEl = i.CoUsEl,
                                        FeUsEl = i.FeUsEl,
                                        Revisado = i.Revisado,
                                        Trasnfe = i.Trasnfe,
                                        CoSucu = i.CoSucu,
                                        Anulado = i.Anulado,
                                        NumTurno = i.NumTurno,
                                        MovtOri = i.MovtOri,
                                        MovtGen = i.MovtGen,
                                        Tracaja = i.Tracaja,
                                        Operador = i.Operador,
                                        Clave = i.Clave,
                                        Moneda2 = i.Moneda2,
                                        Tasa2 = i.Tasa2,
                                        Aux01 = i.Aux01,
                                        Aux02 = i.Aux02,
                                        Campo1 = i.Campo1,
                                        Campo2 = i.Campo2,
                                        Campo3 = i.Campo3,
                                        Campo4 = i.Campo4,
                                        DocSel = i.DocSel
                                        #endregion

                                    }).ToList();
            #endregion

            #region Mov Banco
            List<MovBan> movBanco = (from i in db.MovBan
                                     where i.CobPag == cob.CobNum && i.Origen == "COB"
                                     orderby i.RengNum ascending
                                     select new MovBan
                                     {
                                         #region Campos MovBan
                                         MovNum = i.MovNum,
                                         Codigo = i.Codigo,
                                         DepNum = i.DepNum,
                                         RengNum = i.RengNum,
                                         Origen = i.Origen,
                                         TipoOp = i.TipoOp,
                                         FormaPag = i.FormaPag,
                                         Fecha = i.Fecha,
                                         DocNum = i.DocNum,
                                         Descrip = i.Descrip,
                                         MontoD = i.MontoD,
                                         MontoH = i.MontoH,
                                         Idb = i.Idb,
                                         CtaEgre = i.CtaEgre,
                                         CobPag = i.CobPag,
                                         OriDep = i.OriDep,
                                         DepCon = i.DepCon,
                                         FecCon = i.FecCon,
                                         BancTarj = i.BancTarj,
                                         CodIngben = i.CodIngben,
                                         FechaChe = i.FechaChe,
                                         Feccom = i.Feccom,
                                         Numcom = i.Numcom,
                                         DisCen = i.DisCen,
                                         Moneda = i.Moneda,
                                         Tasa = i.Tasa,
                                         CoUsIn = i.CoUsIn,
                                         FeUsIn = i.FeUsIn,
                                         CoUsMo = i.CoUsMo,
                                         FeUsMo = i.FeUsMo,
                                         CoUsEl = i.CoUsEl,
                                         FeUsEl = i.FeUsEl,
                                         Revisado = i.Revisado,
                                         Trasnfe = i.Trasnfe,
                                         CoSucu = i.CoSucu,
                                         Anulado = i.Anulado,
                                         Comisiontv = i.Comisiontv,
                                         Impuestotv = i.Impuestotv,
                                         Moneda2 = i.Moneda2,
                                         Tasa2 = i.Tasa2,
                                         Aux01 = i.Aux01,
                                         Aux02 = i.Aux02,
                                         Campo1 = i.Campo1,
                                         Campo2 = i.Campo2,
                                         Campo3 = i.Campo3,
                                         Campo4 = i.Campo4
                                         #endregion

                                     }).ToList();
            #endregion

            #region Forma de pago
            List<FormaPagoCobro> rengTip = (from i in db.RengTip
                                            where i.CobNum == cob.CobNum
                                            orderby i.RengNum ascending
                                            select new FormaPagoCobro
                                            {
                                                #region RengTip
                                                CobNum = i.CobNum,
                                                RengNum = i.RengNum,
                                                TipCob = i.TipCob,
                                                Movi = i.Movi,
                                                NumDoc = i.NumDoc,
                                                MontDoc = i.MontDoc,
                                                MontTmp = i.MontTmp,
                                                Moneda = i.Moneda,
                                                Banco = i.Banco,
                                                CodCaja = i.CodCaja,
                                                DesCaja = i.DesCaja,
                                                FecCheq = i.FecCheq,
                                                NombreBan = i.NombreBan,
                                                Numero = i.Numero,
                                                Devuelto = i.Devuelto,
                                                Rowguid = i.Rowguid,
                                                Operador = i.Operador,
                                                Clave = i.Clave,
                                                MovCaj = movCaja,
                                                MovBan = movBanco
                                                #endregion

                                            }).ToList();
            #endregion

            cob.DetaCobro = rengCob;
            cob.FormaPagoCobro = rengTip;

            return cob;
        }
        #endregion

        #region GetAll
        public IEnumerable<EncabCobro> GetAll(string empresaDB)
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

            List<EncabCobro> cob = db.Cobros.Select(cb => new EncabCobro()
            {
                #region Cobros
                CobNum = cb.CobNum,
                Recibo = cb.Recibo,
                CoCli = cb.CoCli,
                CoVen = cb.CoVen,
                FecCob = cb.FecCob,
                Anulado = cb.Anulado,
                Monto = cb.Monto,
                Dppago = cb.Dppago,
                MontNcr = cb.MontNcr,
                Ncr = cb.Ncr,
                TcomiPorc = cb.TcomiPorc,
                TcomiLine = cb.TcomiLine,
                TcomiArt = cb.TcomiArt,
                TcomiConc = cb.TcomiConc,
                Feccom = cb.Feccom,
                Tasa = cb.Tasa,
                Moneda = cb.Moneda,
                Numcom = cb.Numcom,
                DisCen = cb.DisCen,
                Campo1 = cb.Campo1,
                Campo2 = cb.Campo2,
                Campo3 = cb.Campo3,
                Campo4 = cb.Campo4,
                Campo5 = cb.Campo5,
                Campo6 = cb.Campo6,
                Campo7 = cb.Campo7,
                Campo8 = cb.Campo8,
                CoUsIn = cb.CoUsIn,
                FeUsIn = cb.FeUsIn,
                CoUsMo = cb.CoUsMo,
                FeUsMo = cb.FeUsMo,
                CoUsEl = cb.CoUsEl,
                FeUsEl = cb.FeUsEl,
                Recargo = cb.Recargo,
                AdelNum = cb.AdelNum,
                Revisado = cb.Revisado,
                Trasnfe = cb.Trasnfe,
                CoSucu = cb.CoSucu,
                Rowguid = cb.Rowguid,
                Descrip = cb.Descrip,
                NumDev = cb.NumDev,
                Devdinero = cb.Devdinero,
                NumTurno = cb.NumTurno,
                Aux01 = cb.Aux01,
                Aux02 = cb.Aux02,
                Origen = cb.Origen,
                OrigenD = cb.OrigenD,
                DetaCobro = new List<DetaCobro>(),
                FormaPagoCobro = new List<FormaPagoCobro>()
                #endregion

            }).ToList();

            for (int r = 0; r < cob.Count; r++)
            {

                #region Renglones de cobro
                List<DetaCobro> rengCob = (from i in db.RengCob
                                           where i.CobNum == cob[r].CobNum
                                           orderby i.RengNum ascending
                                           select new DetaCobro
                                           {
                                               #region RengCob
                                               CobNum = i.CobNum,
                                               RengNum = i.RengNum,
                                               TpDocCob = i.TpDocCob,
                                               DocNum = i.DocNum,
                                               Neto = i.Neto,
                                               NetoTmp = i.NetoTmp,
                                               Dppago = i.Dppago,
                                               DppagoTmp = i.DppagoTmp,
                                               RengNcr = i.RengNcr,
                                               CoVen = i.CoVen,
                                               Comis1 = i.Comis1,
                                               Comis2 = i.Comis2,
                                               Comis3 = i.Comis3,
                                               Comis4 = i.Comis4,
                                               SignAjuC = i.SignAjuC,
                                               PorcAjuC = i.PorcAjuC,
                                               PorCob = i.PorCob,
                                               ComiCob = i.ComiCob,
                                               MontCob = i.MontCob,
                                               SinoPago = i.SinoPago,
                                               SinoReten = i.SinoReten,
                                               MontoDppago = i.MontoDppago,
                                               MontoReten = i.MontoReten,
                                               ImpPago = i.ImpPago,
                                               MontoObj = i.MontoObj,
                                               Isv = i.Isv,
                                               NroFact = i.NroFact,
                                               Moneda = i.Moneda,
                                               Tasa = i.Tasa,
                                               Numcon = i.Numcon,
                                               Sustraen = i.Sustraen,
                                               Rowguid = i.Rowguid,
                                               CoIslr = i.CoIslr,
                                               FecEmis = i.FecEmis,
                                               FecVenc = i.FecVenc,
                                               Comis5 = i.Comis5,
                                               Comis6 = i.Comis6,
                                               FactIva = i.FactIva,
                                               RetIva = i.RetIva,
                                               PorcRetn = i.PorcRetn,
                                               PorcDesc = i.PorcDesc,
                                               Aux01 = i.Aux01,
                                               Aux02 = i.Aux02,
                                               ProvTer = i.ProvTer,
                                               RengTer = i.RengTer,
                                               FecCom = i.FecCom,
                                               #endregion

                                           }).ToList();
                #endregion

                #region Mov Caja
                List<MovCaj> movCaja = (from i in db.MovCaj
                                        where i.CobPag == cob[r].CobNum && i.Origen == "COB"
                                        orderby i.RengNum ascending
                                        select new MovCaj
                                        {
                                            #region Campos MovCaj
                                            MovNum = i.MovNum,
                                            Codigo = i.Codigo,
                                            DepNum = i.DepNum,
                                            RengNum = i.RengNum,
                                            MovAfec = i.MovAfec,
                                            MonDep = i.MonDep,
                                            Origen = i.Origen,
                                            TipoOp = i.TipoOp,
                                            FormaPag = i.FormaPag,
                                            Fecha = i.Fecha,
                                            DocNum = i.DocNum,
                                            Descrip = i.Descrip,
                                            MontoD = i.MontoD,
                                            MontoH = i.MontoH,
                                            CtaEgre = i.CtaEgre,
                                            CobPag = i.CobPag,
                                            OriDep = i.OriDep,
                                            DepCon = i.DepCon,
                                            BancTarj = i.BancTarj,
                                            CodIngben = i.CodIngben,
                                            FechaChe = i.FechaChe,
                                            Feccom = i.Feccom,
                                            Numcom = i.Numcom,
                                            DisCen = i.DisCen,
                                            Moneda = i.Moneda,
                                            Tasa = i.Tasa,
                                            CoUsIn = i.CoUsIn,
                                            FeUsIn = i.FeUsIn,
                                            CoUsMo = i.CoUsMo,
                                            FeUsMo = i.FeUsMo,
                                            CoUsEl = i.CoUsEl,
                                            FeUsEl = i.FeUsEl,
                                            Revisado = i.Revisado,
                                            Trasnfe = i.Trasnfe,
                                            CoSucu = i.CoSucu,
                                            Anulado = i.Anulado,
                                            NumTurno = i.NumTurno,
                                            MovtOri = i.MovtOri,
                                            MovtGen = i.MovtGen,
                                            Tracaja = i.Tracaja,
                                            Operador = i.Operador,
                                            Clave = i.Clave,
                                            Moneda2 = i.Moneda2,
                                            Tasa2 = i.Tasa2,
                                            Aux01 = i.Aux01,
                                            Aux02 = i.Aux02,
                                            Campo1 = i.Campo1,
                                            Campo2 = i.Campo2,
                                            Campo3 = i.Campo3,
                                            Campo4 = i.Campo4,
                                            DocSel = i.DocSel
                                            #endregion

                                        }).ToList();
                #endregion

                #region Mov Banco
                List<MovBan> movBanco = (from i in db.MovBan
                                         where i.CobPag == cob[r].CobNum && i.Origen == "COB"
                                         orderby i.RengNum ascending
                                         select new MovBan
                                         {
                                             #region Campos MovBan
                                             MovNum = i.MovNum,
                                             Codigo = i.Codigo,
                                             DepNum = i.DepNum,
                                             RengNum = i.RengNum,
                                             Origen = i.Origen,
                                             TipoOp = i.TipoOp,
                                             FormaPag = i.FormaPag,
                                             Fecha = i.Fecha,
                                             DocNum = i.DocNum,
                                             Descrip = i.Descrip,
                                             MontoD = i.MontoD,
                                             MontoH = i.MontoH,
                                             Idb = i.Idb,
                                             CtaEgre = i.CtaEgre,
                                             CobPag = i.CobPag,
                                             OriDep = i.OriDep,
                                             DepCon = i.DepCon,
                                             FecCon = i.FecCon,
                                             BancTarj = i.BancTarj,
                                             CodIngben = i.CodIngben,
                                             FechaChe = i.FechaChe,
                                             Feccom = i.Feccom,
                                             Numcom = i.Numcom,
                                             DisCen = i.DisCen,
                                             Moneda = i.Moneda,
                                             Tasa = i.Tasa,
                                             CoUsIn = i.CoUsIn,
                                             FeUsIn = i.FeUsIn,
                                             CoUsMo = i.CoUsMo,
                                             FeUsMo = i.FeUsMo,
                                             CoUsEl = i.CoUsEl,
                                             FeUsEl = i.FeUsEl,
                                             Revisado = i.Revisado,
                                             Trasnfe = i.Trasnfe,
                                             CoSucu = i.CoSucu,
                                             Anulado = i.Anulado,
                                             Comisiontv = i.Comisiontv,
                                             Impuestotv = i.Impuestotv,
                                             Moneda2 = i.Moneda2,
                                             Tasa2 = i.Tasa2,
                                             Aux01 = i.Aux01,
                                             Aux02 = i.Aux02,
                                             Campo1 = i.Campo1,
                                             Campo2 = i.Campo2,
                                             Campo3 = i.Campo3,
                                             Campo4 = i.Campo4
                                             #endregion

                                         }).ToList();
                #endregion

                #region Forma de pago
                List<FormaPagoCobro> rengTip = (from i in db.RengTip
                                                where i.CobNum == cob[r].CobNum
                                                orderby i.RengNum ascending
                                                select new FormaPagoCobro
                                                {
                                                    #region RengTip
                                                    CobNum = i.CobNum,
                                                    RengNum = i.RengNum,
                                                    TipCob = i.TipCob,
                                                    Movi = i.Movi,
                                                    NumDoc = i.NumDoc,
                                                    MontDoc = i.MontDoc,
                                                    MontTmp = i.MontTmp,
                                                    Moneda = i.Moneda,
                                                    Banco = i.Banco,
                                                    CodCaja = i.CodCaja,
                                                    DesCaja = i.DesCaja,
                                                    FecCheq = i.FecCheq,
                                                    NombreBan = i.NombreBan,
                                                    Numero = i.Numero,
                                                    Devuelto = i.Devuelto,
                                                    Rowguid = i.Rowguid,
                                                    Operador = i.Operador,
                                                    Clave = i.Clave,
                                                    MovCaj = movCaja,
                                                    MovBan = movBanco
                                                    #endregion

                                                }).ToList();
                #endregion

                cob[r].DetaCobro = rengCob;
                cob[r].FormaPagoCobro = rengTip;
            }
            return cob;
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(EncabCobro item, string empresaDB)
        {
            Utilitarios utilitarios = new Utilitarios();

            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                int numeroCajaBanco = 0;

                #region Validar cobro
                ValidarCobro(item, empresaDB);
                #endregion

                #region Buscar consecutivo
                int numeroCobro = utilitarios.BuscarConsecutivo("COBR", item.CoSucu, empresaDB);
                #endregion


                if (numeroCobro > 0)
                {
                    #region Actualización de saldos a documentos en reng_cob
                    foreach (var iDocUpdate in item.DetaCobro)
                    {
                        DocumCc documento = new DocumentosVentasRepositorio().GetDocumento(iDocUpdate.DocNum, iDocUpdate.TpDocCob, empresaDB);
                        documento.Saldo -= iDocUpdate.Neto;
                        documento.CoUsMo = item.CoUsIn;
                        documento.FeUsMo = item.FeUsIn;
                        Response result = new DocumentosVentasRepositorio().Update(documento, empresaDB);

                        if (result.Status == "OK")
                        {
                            if (documento.TipoDoc == "FACT" && documento.Aut)
                            {
                                Factura factura = db.Factura.FirstOrDefault(f => f.FactNum == documento.NroDoc);
                                if (factura != null)
                                {
                                    factura.Saldo -= iDocUpdate.Neto;
                                    factura.CoUsMo = item.CoUsIn;
                                    factura.FeUsMo = item.FeUsIn;
                                    db.Entry(factura).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                    #endregion

                    #region Insertar en cobros
                    Cobros cobro = new Cobros
                    {
                        #region Campos cobro
                        CobNum = numeroCobro,
                        Recibo = item.Recibo,
                        CoCli = item.CoCli,
                        CoVen = item.CoVen,
                        FecCob = item.FecCob,
                        Anulado = item.Anulado,
                        Monto = item.Monto,
                        Dppago = item.Dppago,
                        MontNcr = item.MontNcr,
                        Ncr = item.Ncr,
                        TcomiPorc = item.TcomiPorc,
                        TcomiLine = item.TcomiLine,
                        TcomiArt = item.TcomiArt,
                        TcomiConc = item.TcomiConc,
                        Feccom = item.Feccom,
                        Tasa = item.Tasa,
                        Moneda = item.Moneda,
                        Numcom = item.Numcom,
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
                        Recargo = item.Recargo,
                        AdelNum = item.AdelNum,
                        Revisado = item.Revisado,
                        Trasnfe = item.Trasnfe,
                        CoSucu = item.CoSucu,
                        Descrip = item.Descrip,
                        NumDev = item.NumDev,
                        Devdinero = item.Devdinero,
                        NumTurno = item.NumTurno,
                        Aux01 = item.Aux01,
                        Aux02 = item.Aux02,
                        Origen = item.Origen,
                        OrigenD = item.OrigenD
                        #endregion
                    };
                    db.Cobros.Add(cobro);
                    db.SaveChanges();
                    #endregion

                    #region Insertar formas de pago
                    //List<RengTip> rengTips = new List<RengTip>();
                    foreach (var i in item.FormaPagoCobro)
                    {
                        RengTip rengTip = new RengTip
                        {
                            #region Campos formas de pago
                            CobNum = numeroCobro,
                            RengNum = i.RengNum,
                            TipCob = i.TipCob,
                            Movi = i.Movi,
                            NumDoc = i.NumDoc,
                            MontDoc = i.MontDoc,
                            MontTmp = i.MontDoc,
                            Moneda = i.Moneda,
                            Banco = i.Banco,
                            CodCaja = i.CodCaja,
                            DesCaja = i.DesCaja,
                            FecCheq = i.FecCheq,
                            NombreBan = i.NombreBan,
                            Numero = i.Numero,
                            Devuelto = i.Devuelto,
                            Operador = i.Operador,
                            Clave = i.Clave
                            #endregion
                        };
                        //rengTips.Add(rengTip);
                        db.Entry(rengTip).State = EntityState.Added;
                    }
                    db.SaveChanges();
                    #endregion

                    #region Insertar renglones del cobro
                    foreach (var i in item.DetaCobro)
                    {
                        RengCob rengCob = new RengCob
                        {
                            #region Campos renglones del cobro
                            CobNum = numeroCobro,
                            RengNum = i.RengNum,
                            TpDocCob = i.TpDocCob,
                            DocNum = i.DocNum,
                            Neto = i.Neto,
                            NetoTmp = i.NetoTmp,
                            Dppago = i.Dppago,
                            DppagoTmp = i.DppagoTmp,
                            RengNcr = i.RengNcr,
                            CoVen = i.CoVen,
                            Comis1 = i.Comis1,
                            Comis2 = i.Comis2,
                            Comis3 = i.Comis3,
                            Comis4 = i.Comis4,
                            SignAjuC = i.SignAjuC,
                            PorcAjuC = i.PorcAjuC,
                            PorCob = i.PorCob,
                            ComiCob = i.ComiCob,
                            MontCob = i.MontCob,
                            SinoPago = i.SinoPago,
                            SinoReten = i.SinoReten,
                            MontoDppago = i.MontoDppago,
                            MontoReten = i.MontoReten,
                            ImpPago = i.ImpPago,
                            MontoObj = i.MontoObj,
                            Isv = i.Isv,
                            NroFact = i.NroFact,
                            Moneda = i.Moneda,
                            Tasa = i.Tasa,
                            Numcon = i.Numcon,
                            Sustraen = i.Sustraen,
                            CoIslr = i.CoIslr,
                            FecEmis = i.FecEmis,
                            FecVenc = i.FecVenc,
                            Comis5 = i.Comis5,
                            Comis6 = i.Comis6,
                            FactIva = i.FactIva,
                            RetIva = i.RetIva,
                            PorcRetn = i.PorcRetn,
                            PorcDesc = i.PorcDesc,
                            Aux01 = i.Aux01,
                            Aux02 = i.Aux02,
                            ProvTer = i.ProvTer,
                            RengTer = i.RengTer,
                            FecCom = i.FecCom
                            #endregion
                        };
                        db.Entry(rengCob).State = EntityState.Added;
                    }
                    db.SaveChanges();
                    #endregion

                    #region Insertar movimiento caja/banco
                    foreach (var iFormaPag in item.FormaPagoCobro)
                    {
                        if (iFormaPag.TipCob == "DEPO")
                        {
                            numeroCajaBanco = utilitarios.BuscarConsecutivo("MOVB", item.CoSucu, empresaDB);

                            #region Guarda movimiento banco
                            int lengthDescrCaja = $"Cobro: {numeroCobro} de ".Length;
                            int lengthMaxCliente = 60 - (lengthDescrCaja - 1);
                            var observacion = $"Cobro: {numeroCobro} de {cliente.CliDes.Substring(0, (lengthMaxCliente - lengthDescrCaja)).Trim()}";

                            MovBan movBan = new MovBan
                            {
                                MovNum = numeroCajaBanco,
                                Codigo = iFormaPag.CodCaja,
                                CtaEgre = cliente.CoIngr,
                                Tasa = item.Tasa,
                                Moneda = iFormaPag.Moneda,
                                FeUsIn = item.FeUsIn,
                                FeUsMo = item.FeUsIn,
                                FeUsEl = item.FeUsEl,
                                Fecha = item.FecCob,
                                FechaChe = iFormaPag.FecCheq,
                                FecCon = item.FecCob,
                                Feccom = item.Feccom,
                                CoSucu = item.CoSucu,
                                Origen = "COB",
                                CobPag = numeroCobro,
                                DocNum = iFormaPag.NumDoc,
                                Descrip = observacion,
                                TipoOp = "DP",
                                OriDep = false,
                                MontoH = iFormaPag.MontDoc,
                                CoUsIn = item.CoUsIn,
                                CoUsMo = string.Empty
                            };
                            db.MovBan.Add(movBan);
                            db.SaveChanges();
                            #endregion

                            #region Actualizar saldo en cuenta
                            Cuentas cuenta = db.Cuentas.FirstOrDefault(c => c.CodCta == iFormaPag.CodCaja);
                            cuenta.SaldoA += iFormaPag.MontDoc;
                            db.Entry(cuenta).State = EntityState.Modified;
                            db.SaveChanges();
                            #endregion

                            #region Actualizar rengtip
                            RengTip updateRengtip = db.RengTip.FirstOrDefault(f => f.CobNum == numeroCobro && f.RengNum == iFormaPag.RengNum);
                            updateRengtip.Movi = numeroCajaBanco;
                            updateRengtip.DesCaja = cuenta.NumCta;
                            db.Entry(updateRengtip).State = EntityState.Modified;
                            db.SaveChanges();
                            #endregion

                            #region Actualizar consecutivos movban
                            utilitarios.ActualizarConsecutivo(numeroCajaBanco, "MOVB", item.CoSucu, empresaDB);
                            #endregion
                        }
                        else
                        {
                            numeroCajaBanco = utilitarios.BuscarConsecutivo("MOVC", item.CoSucu, empresaDB);

                            #region Guardar movimiento caja
                            string NomTarjeta = string.Empty;
                            if (!string.IsNullOrEmpty(iFormaPag.Banco.Trim()))
                            {
                                NomTarjeta = db.TarjCre.FirstOrDefault(t => t.CoTar == iFormaPag.Banco.Trim()).DesTar.Trim();
                            }

                            int lengthNomTarjet = $"{NomTarjeta}".Length;
                            int lengthDescrCaja = $"Cobro: { numeroCobro} de ".Length;
                            int lengthMaxCliente = 60 - (lengthNomTarjet + lengthDescrCaja -1);
                            var observacion = $"{(iFormaPag.TipCob == "TARJ" ? NomTarjeta : string.Empty)} Cobro: {numeroCobro} de {cliente.CliDes.Substring(0, (lengthMaxCliente - lengthDescrCaja)).Trim()}";

                            MovCaj movCaj = new MovCaj
                            {
                                MovNum = numeroCajaBanco,
                                Codigo = iFormaPag.CodCaja,
                                CtaEgre = cliente.CoIngr,
                                Tasa = item.Tasa,
                                Moneda = item.Moneda,
                                FeUsIn = item.FeUsIn,
                                FeUsMo = item.FeUsMo,
                                FeUsEl = item.FeUsEl,
                                Fecha = item.FecCob,
                                FechaChe = iFormaPag.FecCheq,
                                Feccom = item.FecCob,
                                CoSucu = item.CoSucu,
                                Origen = "COB",
                                Descrip = observacion,
                                FormaPag = (iFormaPag.TipCob == "TARJ") ? "TJ" : "EF",
                                DocNum = iFormaPag.NumDoc.Trim(),
                                BancTarj = iFormaPag.Banco,
                                MontoH = iFormaPag.MontDoc,
                                TipoOp = "I",
                                CobPag = numeroCobro,
                                OriDep = true,
                                CoUsIn = item.CoUsIn,
                                CoUsMo = string.Empty,
                                CoUsEl = string.Empty
                            };
                            db.MovCaj.Add(movCaj);
                            db.SaveChanges();
                            #endregion

                            #region Actualizar saldo en caja
                            Cajas caja = db.Cajas.FirstOrDefault(c => c.CodCaja == iFormaPag.CodCaja);
                            caja.SaldoA += iFormaPag.MontDoc;
                            db.Entry(caja).State = EntityState.Modified;
                            db.SaveChanges();
                            #endregion

                            #region Actualizar rengtip
                            RengTip updateRengtip = db.RengTip.FirstOrDefault(f => f.CobNum == numeroCobro && f.RengNum == iFormaPag.RengNum);
                            updateRengtip.Movi = numeroCajaBanco;
                            updateRengtip.NombreBan = NomTarjeta;
                            updateRengtip.DesCaja = caja.Descrip;
                            db.Entry(updateRengtip).State = EntityState.Modified;
                            db.SaveChanges();
                            #endregion

                            #region Actualizar consecutivo movcaj
                            utilitarios.ActualizarConsecutivo(numeroCajaBanco, "MOVC", item.CoSucu, empresaDB);
                            #endregion
                        }
                    }
                    #endregion

                    #region Actualizar consecutivo cobros
                    utilitarios.ActualizarConsecutivo(numeroCobro, "COBR", item.CoSucu, empresaDB);
                    #endregion
                }
                else
                {
                    throw new ArgumentException("No se encontró el correlativo configurado para 'COBRO'.");
                }

                return new Response { Status = "OK", Message = "Transacción realizada con éxito" };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Validar cobro
        private void ValidarCobro(EncabCobro obj, string empresaDB)
        {
            #region Verificar cliente
            cliente = new ClientesRepositorio().GetCliente(obj.CoCli, empresaDB);
            if (cliente == null)
            {
                throw new ArgumentException($"El cliente {obj.CoCli.Trim()} indicado para el cobro no existe.");
            }
            #endregion

            #region Verificar vendedor y si tiene funcion de cobrador
            Vendedor vendor = new VendedoresRepositorio().Find(obj.CoVen, empresaDB);
            if (vendor != null)
            {
                if (!vendor.FunCob)
                {
                    throw new ArgumentException($"Vendedor {obj.CoVen} no tiene función de cobrador.");
                }
            }
            else
            {
                throw new ArgumentException($"No existe el vendedor {obj.CoVen}");
            }
            #endregion

            #region Verificar documento que se cancela dentro de reng_cob
            foreach (var iDoc in obj.DetaCobro)
            {
                DocumCc documento = new DocumentosVentasRepositorio().GetDocumento(iDoc.DocNum, iDoc.TpDocCob, empresaDB);

                if (documento == null)
                {
                    throw new ArgumentException($"El documento [{iDoc.TpDocCob}] [{iDoc.DocNum}] indicado en el renglón del cobro [{iDoc.RengNum}] no existe.");
                }
                else
                {
                    if (documento.Saldo <= 0)
                    {
                        throw new ArgumentException($"El documento [{iDoc.TpDocCob}] [{iDoc.DocNum}] indicado en el renglón del cobro {iDoc.RengNum} no posee saldo.");
                    }
                    if (iDoc.Neto > documento.Saldo)
                    {
                        throw new ArgumentException($"El documento [{iDoc.TpDocCob}] [{iDoc.DocNum}] indicado en el renglón del cobro [{iDoc.RengNum}] posee un saldo inferior al monto indicado.");
                    }
                    if (documento.CoCli.Trim() != obj.CoCli.Trim())
                    {
                        throw new ArgumentException($"El documento [{iDoc.TpDocCob}] [{iDoc.DocNum}] indicado en el renglón del cobro [{iDoc.RengNum}] es de un cliente diferente.");
                    }
                }
            }
            #endregion

            #region Verificar datos en forma de pago
            foreach (var iTPago in obj.FormaPagoCobro)
            {
                if (iTPago.TipCob == "DEPO")
                {
                    if (string.IsNullOrEmpty(iTPago.NumDoc))
                    {
                        throw new ArgumentException($"Debe indicar el documento en forma de pago, renglon {iTPago.RengNum}.");
                    }
                    else
                    {
                        #region Verificar el nro del documento en forma de pago que no este duplicado.
                        MovBan banco = new MovimientosBancoRepositorio().GetMovBanxDoc(iTPago.NumDoc, "COB", empresaDB);
                        if (banco != null)
                        {
                            throw new ArgumentException($"El documento indicado en el renglón {iTPago.RengNum} de la forma de pago ya existe.");
                        }
                        #endregion
                    }

                    #region Verificar cuenta bancaria
                    Cuentas cuenta = new CuentasBancariasRepositorio().GetCuenta(iTPago.CodCaja, empresaDB);
                    if (cuenta == null)
                    {
                        throw new ArgumentException($"No existe la cuenta bancaria indicada en la forma de pago renglón {iTPago.RengNum}.");
                    }
                    else
                    {
                        iTPago.DesCaja = cuenta.NumCta;
                    }
                    #endregion

                }
            }
            #endregion
        }
        #endregion

        #region Update
        public Response Update(EncabCobro item, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
