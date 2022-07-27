using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace absenceClass
{
    public class Class1
    {
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-QV3FUH3\SQLEXPRESS;Initial Catalog=Ista;Integrated Security=True");
        public static SqlDataAdapter adapt = new SqlDataAdapter();
        public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();
        public static void save(string tab)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(adapt);
            adapt.Update(ds.Tables[tab]);
        }

        public static string UserA { get; set; }
        public static int codeA { get; set; }
    }
}
