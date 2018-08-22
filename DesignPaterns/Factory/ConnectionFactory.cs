using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DesignPaterns.Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = DesignPaterns.Properties.Settings.Default.StringConexao;
            conexao.Open();
            return conexao;
        }
    }
}
