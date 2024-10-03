using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerProvider
{
    public class DBConnect
    {
        string strConn = "Data Source=LAPTOP-GQAMABND;Initial Catalog=QL_NhaTro;User ID=sa;Password=123";
        SqlConnection conn;

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public DBConnect()
        {
            Conn = new SqlConnection(strConn);
        }



        public void open()
        {
            if (Conn.State == System.Data.ConnectionState.Closed)
                Conn.Open();
        }

        public void close()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
                Conn.Close();
        }

        public SqlDataReader ExecuteQuery(string query)
        {
            open();
            SqlCommand cmd = new SqlCommand(query, Conn);
            return cmd.ExecuteReader();
        }

        public int ExecuteNonQuery(string query)
        {
            open();
            SqlCommand cmd = new SqlCommand(query, Conn);
            return cmd.ExecuteNonQuery();
        }

        public object ExecuteScalar(string query)
        {
            open();
            SqlCommand cmd = new SqlCommand(query, Conn);
            return cmd.ExecuteScalar();
        }


    }
}
