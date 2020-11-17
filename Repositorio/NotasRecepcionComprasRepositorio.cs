namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class NotasRecepcionComprasRepositorio : IRepositorio<EncabNotRec>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        //readonly Utilitarios utilitarios = new Utilitarios();

        #region Find
        public EncabNotRec Find(int key, string empresaDB)
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
            EncabNotRec nota = db.NotRec.Select(n => new EncabNotRec()
            {
                #region Campos
                FactNum = n.FactNum,
                Factura = n.Factura,
                Contrib = n.Contrib,
                DisCen = n.DisCen,
                Nombre = n.Nombre,
                Rif = n.Rif,
                Nit = n.Nit,
                Status = n.Status,
                Comentario = n.Comentario,
                Descrip = n.Descrip,
                Saldo = n.Saldo,
                FecEmis = n.FecEmis,
                FecVenc = n.FecVenc,
                CoCli = n.CoCli,
                CoVen = n.CoVen,
                CoTran = n.CoTran,
                DirEnt = n.DirEnt,
                FormaPag = n.FormaPag,
                TotBruto = n.TotBruto,
                TotNeto = n.TotNeto,
                GlobDesc = n.GlobDesc,
                TotReca = n.TotReca,
                PorcGdesc = n.PorcGdesc,
                PorcReca = n.PorcReca,
                TotalUc = n.TotalUc,
                TotalCp = n.TotalCp,
                TotFlete = n.TotFlete,
                MontoDev = n.MontoDev,
                Totklu = n.Totklu,
                Anulada = n.Anulada,
                Impresa = n.Impresa,
                Iva = n.Iva,
                IvaDev = n.IvaDev,
                Feccom = n.Feccom,
                Numcom = n.Numcom,
                Tasa = n.Tasa,
                Moneda = n.Moneda,
                CtaContab = n.CtaContab,
                Seriales = n.Seriales,
                Tasag = n.Tasag,
                Tasag10 = n.Tasag10,
                Tasag20 = n.Tasag20,
                Campo1 = n.Campo1,
                Campo2 = n.Campo2,
                Campo3 = n.Campo3,
                Campo4 = n.Campo4,
                Campo5 = n.Campo5,
                Campo6 = n.Campo6,
                Campo7 = n.Campo7,
                Campo8 = n.Campo8,
                CoUsIn = n.CoUsIn,
                FeUsIn = n.FeUsIn,
                CoUsMo = n.CoUsMo,
                FeUsMo = n.FeUsMo,
                CoUsEl = n.CoUsEl,
                FeUsEl = n.FeUsEl,
                Revisado = n.Revisado,
                Trasnfe = n.Trasnfe,
                CoSucu = n.CoSucu,
                Rowguid = n.Rowguid,
                MonIlc = n.MonIlc,
                Otros1 = n.Otros1,
                Otros2 = n.Otros2,
                Otros3 = n.Otros3,
                Aux01 = n.Aux01,
                Aux02 = n.Aux02,
                Salestax = n.Salestax,
                Origen = n.Origen,
                OrigenD = n.OrigenD,
                StaProd = n.StaProd,
                Telefono = n.Telefono
                #endregion

            }).FirstOrDefault(n => n.FactNum == key);

            List<DetaNotaRecepcion> reng = (from i in db.RengNdr
                                            where i.FactNum == key
                                            orderby i.RengNum ascending
                                            select new DetaNotaRecepcion()
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
                                                CoAlma2 = i.CoAlma2,
                                                Aux01 = i.Aux01,
                                                Aux02 = i.Aux02,
                                                CantProd = i.CantProd,
                                                ImpProd = i.ImpProd
                                                #endregion

                                            }).ToList();
            nota.DetaNotaRecepcion = reng;
            return nota;
        }
        #endregion

        #region GetAll
        public IEnumerable<EncabNotRec> GetAll(string empresaDB)
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
            List<EncabNotRec> nota = db.NotRec.Select(n => new EncabNotRec()
            {
                #region Campos
                FactNum = n.FactNum,
                Factura = n.Factura,
                Contrib = n.Contrib,
                DisCen = n.DisCen,
                Nombre = n.Nombre,
                Rif = n.Rif,
                Nit = n.Nit,
                Status = n.Status,
                Comentario = n.Comentario,
                Descrip = n.Descrip,
                Saldo = n.Saldo,
                FecEmis = n.FecEmis,
                FecVenc = n.FecVenc,
                CoCli = n.CoCli,
                CoVen = n.CoVen,
                CoTran = n.CoTran,
                DirEnt = n.DirEnt,
                FormaPag = n.FormaPag,
                TotBruto = n.TotBruto,
                TotNeto = n.TotNeto,
                GlobDesc = n.GlobDesc,
                TotReca = n.TotReca,
                PorcGdesc = n.PorcGdesc,
                PorcReca = n.PorcReca,
                TotalUc = n.TotalUc,
                TotalCp = n.TotalCp,
                TotFlete = n.TotFlete,
                MontoDev = n.MontoDev,
                Totklu = n.Totklu,
                Anulada = n.Anulada,
                Impresa = n.Impresa,
                Iva = n.Iva,
                IvaDev = n.IvaDev,
                Feccom = n.Feccom,
                Numcom = n.Numcom,
                Tasa = n.Tasa,
                Moneda = n.Moneda,
                CtaContab = n.CtaContab,
                Seriales = n.Seriales,
                Tasag = n.Tasag,
                Tasag10 = n.Tasag10,
                Tasag20 = n.Tasag20,
                Campo1 = n.Campo1,
                Campo2 = n.Campo2,
                Campo3 = n.Campo3,
                Campo4 = n.Campo4,
                Campo5 = n.Campo5,
                Campo6 = n.Campo6,
                Campo7 = n.Campo7,
                Campo8 = n.Campo8,
                CoUsIn = n.CoUsIn,
                FeUsIn = n.FeUsIn,
                CoUsMo = n.CoUsMo,
                FeUsMo = n.FeUsMo,
                CoUsEl = n.CoUsEl,
                FeUsEl = n.FeUsEl,
                Revisado = n.Revisado,
                Trasnfe = n.Trasnfe,
                CoSucu = n.CoSucu,
                Rowguid = n.Rowguid,
                MonIlc = n.MonIlc,
                Otros1 = n.Otros1,
                Otros2 = n.Otros2,
                Otros3 = n.Otros3,
                Aux01 = n.Aux01,
                Aux02 = n.Aux02,
                Salestax = n.Salestax,
                Origen = n.Origen,
                OrigenD = n.OrigenD,
                StaProd = n.StaProd,
                Telefono = n.Telefono
                #endregion

            }).ToList();

            for (int r = 0; r < nota.Count; r++)
            {
                List<DetaNotaRecepcion> reng = (from i in db.RengNdr
                                                where i.FactNum == nota[r].FactNum
                                                orderby i.RengNum ascending
                                                select new DetaNotaRecepcion()
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
                                                    CoAlma2 = i.CoAlma2,
                                                    Aux01 = i.Aux01,
                                                    Aux02 = i.Aux02,
                                                    CantProd = i.CantProd,
                                                    ImpProd = i.ImpProd
                                                    #endregion

                                                }).ToList();
                nota[r].DetaNotaRecepcion = reng;
            }

            return nota;
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(EncabNotRec item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                Utilitarios utilitarios = new Utilitarios();

                #region Buscar consecutivo
                var numeroNRecepcion = utilitarios.BuscarConsecutivo("NREC", item.CoSucu, empresaDB);
                #endregion

                if (numeroNRecepcion > 0)
                {
                    #region Calcular exento para el DisCen
                    decimal TotalExento = (decimal)(from exento in item.DetaNotaRecepcion where exento.TipoImp == "6" select exento).Sum(t => t.RengNeto);
                    #endregion

                    #region Construcción de DisCen
                    string DisCen = utilitarios.ArmarDisCen(item.FecEmis, (decimal)item.TotBruto, item.Iva, TotalExento, empresaDB);
                    #endregion

                    #region Encabezado factura
                    NotRec NotaRec = new NotRec
                    {
                        #region Campos
                        FactNum = numeroNRecepcion,
                        Factura = item.Factura,
                        Contrib = item.Contrib,
                        DisCen = item.DisCen,
                        Nombre = item.Nombre,
                        Rif = item.Rif,
                        Nit = item.Nit,
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
                        CtaContab = item.CtaContab,
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
                        CoSucu = item.CoSucu,
                        Rowguid = item.Rowguid,
                        MonIlc = item.MonIlc,
                        Otros1 = item.Otros1,
                        Otros2 = item.Otros2,
                        Otros3 = item.Otros3,
                        Aux01 = item.Aux01,
                        Aux02 = item.Aux02,
                        Salestax = item.Salestax,
                        Origen = item.Origen,
                        OrigenD = item.OrigenD,
                        StaProd = item.StaProd,
                        Telefono = item.Telefono
                        #endregion
                    };
                    db.Entry(NotaRec).State = EntityState.Added;
                    #endregion

                    #region Renglones
                    List<RengNdr> Renglones = new List<RengNdr>();

                    foreach (var i in item.DetaNotaRecepcion)
                    {
                        RengNdr reng_ndr = new RengNdr
                        {
                            #region Campos
                            FactNum = numeroNRecepcion,
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
                            CoAlma2 = i.CoAlma2,
                            Aux01 = i.Aux01,
                            Aux02 = i.Aux02,
                            CantProd = i.CantProd,
                            ImpProd = i.ImpProd
                            #endregion
                        };
                        Renglones.Add(reng_ndr);
                    }

                    #region Actualizacion de stock
                    foreach (var i in Renglones)
                    {
                        utilitarios.ActualizarStockArticuloAlmacen(i.CoArt, i.CoAlma, i.TotalArt, true, empresaDB);
                        db.Entry(i).State = EntityState.Added;

                        #region Actualización de costos en articulo

                        #region Valor de la tasa OM parametrizada.
                        decimal tasa = db.Moneda.FirstOrDefault(m => m.CoMone.Trim() == db.ParEmp.FirstOrDefault().MoneArt.Trim()).Cambio;
                        #endregion

                        Art art = db.Art.FirstOrDefault(a => a.CoArt.Trim() == i.CoArt.Trim());
                        art.CosUnAn = art.UltCosUn;
                        art.FecCosAn = art.FecUltCo;

                        art.UltCosUn = i.PrecVta;
                        art.FecUltCo = DateTime.Now;

                        art.UltCosDo = art.UltCosOm;
                        art.FecCosDo = art.FecUltOm;
                        art.UltCosOm = i.PrecVta / tasa;
                        art.FecUltOm = DateTime.Now;

                        art.CosProUn = i.PrecVta;
                        art.FecCosPr = DateTime.Now;

                        art.CosProOm = i.PrecVta / tasa;
                        art.FecProOm = DateTime.Now;

                        art.CoUsMo = item.CoUsMo;
                        art.FeUsMo = DateTime.Now;

                        db.Entry(art).State = EntityState.Modified;
                        #endregion
                    }
                    #endregion

                    #endregion

                    db.SaveChanges();

                    #region Actualizar consecutivo
                    utilitarios.ActualizarConsecutivo(numeroNRecepcion, "NREC", item.CoSucu, empresaDB);
                    #endregion

                    return new Response { Status = "OK", Message = "Transacción realizada con éxito.", FacturaID = numeroNRecepcion.ToString() };
                }
                else
                {
                    throw new ArgumentException("No se encontró el correlativo configurado para 'NREC'.");
                }
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Update
        public Response Update(EncabNotRec item, string empresaDB)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
