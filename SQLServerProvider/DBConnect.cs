using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerProvider
{
    public class DBConnect
    {
        string strConn = "Data Source=LAPTOP-85VQT4K5\\SQLEXPRESS05;Initial Catalog=QL_NhaTro;User ID=sa;Password=123";
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
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection); 
        }


        public int ExecuteNonQuery(string query)
        {
            open();
            SqlCommand cmd = new SqlCommand(query, Conn);
            int result = cmd.ExecuteNonQuery();
            close();
            return result;
        }


        public object ExecuteScalar(string query)
        {
            open();
            SqlCommand cmd = new SqlCommand(query, Conn);
            object result = cmd.ExecuteScalar();
            close();
            return result;
        }

        public DataTable GetDataTable(string query)
        {
            open();
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            close();
            return dt;
        }

    }
}
