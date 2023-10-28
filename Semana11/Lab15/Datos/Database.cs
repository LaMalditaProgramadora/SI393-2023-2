using System.Data.SqlClient;

namespace Datos
{
    internal class Database
    {
        private SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = db_lab15; Integrated Security = True");
        public SqlConnection ConectaDb()
        {
            try
            {
                conn.Open();
                return conn;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
        public void DesconectaDb()
        {
            conn.Close();
        }
    }
}
