using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Lopushok
{
    public class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1_Login());
        }

        //--------------------------------------------------------------

        public static NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=123456789;Database=lopushok");

        //--------------------------------------------------------------

        public static string dataProduct = "SELECT p.id, p.title, pt.title, p.articlenumber, p.description, p.image," +
            " p.productionpersoncount, p.productionworkshopnumber, p.mincostforagent, string_agg(m.title, ', ') AS material FROM product p" +
            " JOIN productType pt ON p.producttypeid = pt.id JOIN productmaterial pm ON p.id = pm.productid " +
            "JOIN material m ON pm.materialid = m.id GROUP BY p.id, p.title, pt.title, p.articlenumber, p.description, " +
            "p.image, p.productionpersoncount, p.productionworkshopnumber, p.mincostforagent";
        public static List<Product> GetDataFromDatabase(string query)
        {
            List<Product> products = new List<Product>();
            string imageFolderPath = @"E:\STUDY\4 КУРС\2 СЕМЕСТР\Промежуточный экзамен\Промежуточный контроль\Сессия 1";
            string relativeImagePath = "";
            string absoluteImagePath = "";

            using (NpgsqlCommand requestOutput = new NpgsqlCommand(query, Program.connection))
            {
                if (Program.connection.State == ConnectionState.Closed)
                {
                    Program.connection.Open();
                }

                using (NpgsqlDataReader reader = requestOutput.ExecuteReader())
                {
                    while (reader.Read())
                    {


                        relativeImagePath = reader.IsDBNull(5) ? @"\products\picture.png" : reader.GetString(5);
                        absoluteImagePath = Path.Combine(imageFolderPath, relativeImagePath.TrimStart('\\'));
                        string materialsConcatenated = reader.GetString(9);
                        string[] materials = materialsConcatenated.Split(',');

                        Product product = new Product
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            ProductType = reader.GetString(2),
                            ArticleNumber = reader.GetString(3),
                            Description = reader.GetString(4),
                            Image = absoluteImagePath,
                            ProductionPersonCount = reader.GetInt32(6),
                            ProductionWorkshopNumber = reader.GetInt32(7),
                            MinCostForAgent = reader.GetDecimal(8),
                            Material = materials
                        };

                        products.Add(product);
                    }
                }
                connection.Close();
            }
            return products;
        }

        //--------------------------------------------------------------
        public static bool DeleteProduct(int id)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить продукт?", "Подтвердите удаление", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM product WHERE id = @productId", Program.connection))
                {
                    if (Program.connection.State == ConnectionState.Closed)
                    {
                        Program.connection.Open();
                    }
                    command.Parameters.AddWithValue("@productId", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        connection.Close();
                        return true; // Продукт был успешно удален
                    }
                }
            }
            return false; // Произошла ошибка при удалении продукта или пользователь отменил удаление
        }
        //--------------------------------------------------------------
        public static bool UpdateProduct(int Id, string Title, string ProductType, string ArticleNumber,
      string Description, string Image, int ProductionPersonCount, int ProductionWorkshopNumber, decimal MinCostForAgent)
        {
            bool success = false;

            using (NpgsqlCommand updateProduct = new NpgsqlCommand())
            {
                if (Program.connection.State == ConnectionState.Closed)
                {
                    Program.connection.Open();
                }

                updateProduct.Connection = Program.connection;
                updateProduct.CommandText = @"UPDATE Product p
                                      SET Title = @title, ProductTypeId = (SELECT Id FROM productType WHERE Title = @productType),
                                          ArticleNumber = @articleNumber, Description = @description, Image = @image,
                                          ProductionPersonCount = @productionPersonCount, ProductionWorkshopNumber = @productionWorkshopNumber,  MinCostForAgent = @minCostForAgent
                                      WHERE Id = @id";

                updateProduct.Parameters.AddWithValue("@title", Title);
                updateProduct.Parameters.AddWithValue("@productType", ProductType);
                updateProduct.Parameters.AddWithValue("@minCostForAgent", MinCostForAgent);
                updateProduct.Parameters.AddWithValue("@articleNumber", ArticleNumber);
                updateProduct.Parameters.AddWithValue("@description", Description);
                updateProduct.Parameters.AddWithValue("@image", Image);
                updateProduct.Parameters.AddWithValue("@productionPersonCount", ProductionPersonCount);
                updateProduct.Parameters.AddWithValue("@productionWorkshopNumber", ProductionWorkshopNumber);
                updateProduct.Parameters.AddWithValue("@id", Id);

                int rowsAffected = updateProduct.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
            }

            return success;
        }

        //--------------------------------------------------------------
    }
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ProductType { get; set; }
        public string ArticleNumber { get; set; }
        public string[] Material { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int ProductionPersonCount { get; set; }
        public int ProductionWorkshopNumber { get; set; }
        public decimal MinCostForAgent { get; set; }

    }
}
