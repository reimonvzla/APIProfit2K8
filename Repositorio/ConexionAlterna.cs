namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Data.Entity.Core.EntityClient;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Models;

    public class ConexionAlterna
    {
        readonly ProfitAdmin2K8 db = new ProfitAdmin2K8();

        #region Conexion version Code First.
        internal string CrearCadenaConexion(string dataBase)
        {
            //string DataSource = GetServerName();
            string DataSource = "DESKTOP-9RKQG9O"; //"MARINO_ADMON";
            // Build the connection string from the provided datasource and database
            String connString = $"data source={DataSource};initial catalog={dataBase};user id=profit;password=profit;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";

            // Build the MetaData... feel free to copy/paste it from the connection string in the config file.
            EntityConnectionStringBuilder esb = new EntityConnectionStringBuilder();
            esb.Metadata = "res://*/ModeloSQL.Administrativo2K12Model.csdl|" +
                           "res://*/ModeloSQL.Administrativo2K12Model.ssdl|" +
                           "res://*/ModeloSQL.Administrativo2K12Model.msl";
            esb.Provider = "System.Data.SqlClient";
            esb.ProviderConnectionString = connString;

            // Generate the full string and return it
            return esb.ToString();

        }
        #endregion

        #region Conexion Core 3.x
        //public static
        internal DbContextOptions<ProfitAdmin2K8> GetDbContextOptions(string dataBase)
        {
            /*Buscar el servidor en appsetting.json*/
            /*Se excluye el metodo GetServerName*/
            /*R.M.: 02/10/2020*/

            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            string DataSource = configuration["Servidor"];
            //string DataSource = GetServerName();

            String connString = $"Server={DataSource};Database={dataBase};User Id=profit;Password=profit;";

            return new DbContextOptionsBuilder<ProfitAdmin2K8>()
                  .UseSqlServer(connString).Options;

        }
        #endregion

        #region GetServerName
        private string GetServerName()
        {
            string serverName = "";

            using (var command = db.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT @@SERVERNAME ServerName";
                db.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        while (result.Read())
                        {
                            serverName = result.GetString(0);
                        }
                    }
                }
                command.Connection.Close();
            }
            return serverName;
        }
        #endregion
    }
}
