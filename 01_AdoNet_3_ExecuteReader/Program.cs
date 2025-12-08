using System.Data.SqlClient;

namespace _01_AdoNet_3_ExecuteReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source = 202-3\\SQLDERS; Initial Catalog = NORTHWND; User Id=sa; Password=1");

            SqlCommand cmd = new SqlCommand("Select * from Categories", con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader(); //Select komutu ile okuma işlemini çalıştırır.

            List<Category> categories = new List<Category>();

            while (reader.Read()) //Select komutu ile okunan dataset satır satır okunur.
            {
                Category cat = new Category();
                cat.CategoryID = (int)reader[0];
                cat.CategoryName = reader[1].ToString();
                cat.Description = reader.GetString(2);

                categories.Add(cat);
            }
            con.Close();

            foreach (Category item in categories)
            {
                Console.WriteLine(item.CategoryID);
                Console.WriteLine(item.CategoryName);
                Console.WriteLine(item.Description);
                Console.WriteLine("*************");
            }


        }
    }
}
