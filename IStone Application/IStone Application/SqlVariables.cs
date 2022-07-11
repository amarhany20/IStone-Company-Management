using System.Data.SqlClient;
namespace IStone_Application
{
    class SqlVariables
    {
        public static string ipv4 ;
        public static void SetIp(string ip)
        {
            ipv4 = ip;
               con = new SqlConnection($"Data Source=\"{ipv4}, 1433\";Initial Catalog=IStone;User ID=admin;Password=Admin1");
        }
        public static SqlConnection con = new SqlConnection($"Data Source=\"{ipv4}, 1433\";Initial Catalog=IStone;User ID=admin;Password=Admin1");

    }
}
