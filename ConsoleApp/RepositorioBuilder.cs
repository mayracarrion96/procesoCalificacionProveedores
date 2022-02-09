using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class RepositorioBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres, Memoria, MySql }
        static Repositorio db;

        public static Repositorio Crear()
        {
            // Lee la configuración acerca de qué base usar del archivo App.config
            string dbtipo;
            string conn;

            dbtipo = ConfigurationManager.AppSettings[DBTipo];
            if (dbtipo == null)
            {
                dbtipo = "SqlServer";
                conn = "Server = DESKTOP-975JAJB; Initial Catalog = SGA; trusted_connection = true;";
                //dbtipo = "Postgres";
                //conn = "Host=localhost; Database=SCP; Username=postgres; Password=12345;";
                //dbtipo = "MySql";
                //conn = "server=localhost; user=root; password=mc1723950968; database=SCP;";
            }
            else
            {
                conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;
            }
            
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

            // Construye la conección acorde con el tipo
            DbContextOptions<Repositorio> contextOptions;
            switch (dbtipo)
            {
                case nameof(DBTipoConn.SqlServer):
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.Postgres):
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.MySql):
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseMySql(conn, serverVersion)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseInMemoryDatabase(conn)
                        .Options;
                    break;
            }

            db = new Repositorio(contextOptions);

            return db;
        }
    }
}
