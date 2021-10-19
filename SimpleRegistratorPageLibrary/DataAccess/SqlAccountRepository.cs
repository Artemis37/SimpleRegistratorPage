using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using SimpleRegistratorPageLibrary.Model;

namespace SimpleRegistratorPageLibrary.DataAccess
{
    class SqlAccountRepository
    {
        static string getConnectionString(string DBName = "Default")
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var Configuration = builder.Build();
            //return Configuration.GetSection("ConnectionStrings").GetChildren().ToList()[0].Value;
            return Configuration.GetConnectionString(DBName);
        }

        public List<T> LoadAccount<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(getConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public void SaveAccount(string sql, object param = null)
        {
            using (IDbConnection cnn = new SqlConnection(getConnectionString()))
            {
               cnn.Execute(sql, param);
            }
        }
    }
}
