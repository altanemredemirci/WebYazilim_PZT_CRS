using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _01_AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# ile SQL haberleştiren yapılara ORM denir.
            // ORM(Obejct Relation Mapping) - Nesne İlişki Yönetimi
            /*
            ******* Popüler Micro ORM Araçları *******
            * Ado.Net 42ms 'de haberleşiyor.
            * Dapper  44ms 'de haberleşiyor.
            * Entity Framework 682 ms 'de haberleşiyor.
                * Code First
                * Model First
                * Database First
                * Code First(Varolan Database)
             
             */

            #region SQLCONNECTION

            //Windows Authentication
            //SqlConnection connect = new SqlConnection("Data Source=202-3\\SQLDERS; Initial Catalog=NORTHWND; Integrated Security=true");

            //SQL Server Authentication
            SqlConnection connect = new SqlConnection("Data Source = 202-3\\SQLDERS; Initial Catalog = NORTHWND; User Id=sa; Password=1");

            connect.Open();
            Console.WriteLine(connect.State);
            connect.Close();
            Console.WriteLine(connect.State);

            #endregion

        }
    }
}
