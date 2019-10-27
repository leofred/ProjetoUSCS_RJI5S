using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProjetoUSCS_RJI5S.Class
{
    class Database
    {

        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlCommandBuilder cb;

        public static String server = "127.0.0.1";
        public static String port = "3306";
        public static String user = "root";
        public static String password = "";
        public static String database = "uscsnet";

        public void Conectar()
        {
            if (conn != null)
                conn.Close();

            string connStr = String.Format("Server={0};port={1};user id={2};password={3}; database={4};pooling=false", server, port, user, password, database);

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public long ExecutarComandoSQL(string comandoSql, bool ReturnLastInsertedId = false)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            comando.ExecuteNonQuery();
            long id = comando.LastInsertedId;
            conn.Close();
            if (ReturnLastInsertedId == true)
            {
                return id;
            }
            else
            {
                return 0;
            }
        }

        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }

        public MySqlDataReader RetDataReader(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            return dr;
        }

    }
}
