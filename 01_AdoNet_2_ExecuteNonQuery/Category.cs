using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AdoNet_2_ExecuteNonQuery
{
    internal class Category
    {


        //Data Access Modifier
        /*
         public   :Bütün Solution tarafından erişilebilir.
         internal :Sadece tanımlı olduğu proje tarafından erişilebilir.
         private  :Sadece tanımlı olduğu class içerisinde erişilebilir.
         protected:Miras olarak aktarılan sınıfı içerisinde erişilebilir.
         
         */

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }


        public static void CategoryEkle()
        {
            SqlConnection con = new SqlConnection("Data Source = 202-3\\SQLDERS; Initial Catalog = NORTHWND; User Id=sa; Password=1");

            Category category = new Category();

            Console.WriteLine("Category Name:");
            category.CategoryName = Console.ReadLine();

            Console.WriteLine("Category Description:");
            category.Description = Console.ReadLine();

            //SqlCommand: Sql e ait CRUD script(sql kodu) tanımlanmasını sağlar.
            SqlCommand cmd = new SqlCommand($"Insert into Categories (CategoryName,Description) values ('{category.CategoryName}','{category.Description}')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public static void CategorySil(int Id)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = 202-3\\SQLDERS; Initial Catalog = NORTHWND; User Id=sa; Password=1");

                SqlCommand cmd = new SqlCommand($"Delete from Categories where categoryId={Id}", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Silme işlemi başarılı");
            }

            catch
            {
                Console.WriteLine("Silme işlemi başarısız!!");
            }
        }

        public static void CategoryGuncelle(Category cat)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = 202-3\\SQLDERS; Initial Catalog = NORTHWND; User Id=sa; Password=1");

                SqlCommand cmd = new SqlCommand($"Update Categories set categoryName='{cat.CategoryName}', description='{cat.Description}'  where categoryId={cat.CategoryID}", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Güncelleme işlemi başarılı");
            }

            catch
            {
                Console.WriteLine("Güncelleme işlemi başarısız!!");
            }
        }

    }
}
