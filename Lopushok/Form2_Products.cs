using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lopushok
{
    public partial class Form2_Products : Form
    {
        public Form2_Products()
        {
            InitializeComponent();
            LoadProducts(Program.dataProduct);
            cb_sort.Items.Add("По возрастанию");
            cb_sort.Items.Add("По убыванию");
            cb_filter.Items.Add("Все типы");
            cb_filter.Items.Add("Два слоя");
            cb_filter.Items.Add("Детская");
            cb_filter.Items.Add("Один слой");
            cb_filter.Items.Add("Супер мягкая");
            cb_filter.Items.Add("Три слоя");
        }


        public void LoadProducts(string query)
        {
            List<Product> products = Program.GetDataFromDatabase(query);

            int spacingVertical = 20;
            int spacingHorizontal = 40;

            int panelWidth = panel_ListProducts.Width - spacingHorizontal * 2;
            panel_ListProducts.Controls.Clear();
            // Создание пользовательских контролов для каждой позиции продукции и добавление их в панель
            for (int i = 0; i < products.Count; i++)
            {
                ProductCard productControl = new ProductCard();
                productControl.Product = products[i];

                // Устанавливаем позицию по вертикали с учетом отступа
                if (i == 0)
                {
                    productControl.Location = new Point(spacingHorizontal, 0); // Если это первая карточка, размещаем ее в верхнем левом углу с отступом по горизонтали
                }
                else
                {
                    ProductCard previousControl = (ProductCard)panel_ListProducts.Controls[i - 1];
                    productControl.Location = new Point(spacingHorizontal, previousControl.Bottom + spacingVertical); // Устанавливаем позицию новой карточки относительно предыдущей с отступом по горизонтали и вертикали
                }

                productControl.Width = panelWidth; // Устанавливаем ширину контрола, равную ширине панели минус отступы по горизонтали

                panel_ListProducts.Controls.Add(productControl);
            }
        }

        private void Form2_Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Products_Load(object sender, EventArgs e)
        {
            cb_sort.Text = "Сортировка";
            cb_filter.Text = "Фильтрация";
        }

        public static string query = "SELECT p.id, p.title, pt.title, p.articlenumber, p.description, p.image," +
                   " p.productionpersoncount, p.productionworkshopnumber, p.mincostforagent, string_agg(m.title, ', ') AS material FROM product p" +
                   " JOIN productType pt ON p.producttypeid = pt.id JOIN productmaterial pm ON p.id = pm.productid " +
                   "JOIN material m ON pm.materialid = m.id";

        string originalQuery = query;
        private void cb_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortOption = cb_sort.SelectedItem.ToString();
            query += " GROUP BY p.id, p.title, pt.title, p.articlenumber, p.description, " +
               "p.image, p.productionpersoncount, p.productionworkshopnumber, p.mincostforagent";

            if (selectedSortOption == "По возрастанию")
            {
                query += " ORDER BY p.title ASC";
            }
            else if (selectedSortOption == "По убыванию")
            {
                query += " ORDER BY p.title DESC";
            }

            ClearPanel(panel_ListProducts);
            LoadProducts(query);
            query = originalQuery;
        }

        private void ClearPanel(Panel panel)
        {
            panel.Controls.Clear();
        }

        string TypeTitle = "";
        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilterOption = cb_filter.SelectedItem.ToString();

            if (selectedFilterOption != "Все типы")
            {
                switch (selectedFilterOption)
                {

                    case "Два слоя":
                        TypeTitle = "Два слоя";
                        break;

                    case "Один слой":
                        TypeTitle = "Один слой";
                        break;

                    case "Детская":
                        TypeTitle = "Детская";
                        break;

                    case "Супер мягкая":
                        TypeTitle = "Супер мягкая";
                        break;

                    case "Три слоя":
                        TypeTitle = "Три слоя";
                        break;
                }

                string filterQuery = $"{query} WHERE pt.title = '{TypeTitle}' GROUP BY p.id, p.title, pt.title, p.articlenumber, p.description, p.image, p.productionpersoncount, p.productionworkshopnumber, p.mincostforagent";
                ClearPanel(panel_ListProducts);
                LoadProducts(filterQuery);
            }
            else if (selectedFilterOption == "Все типы")
            {
                ClearPanel(panel_ListProducts);
                LoadProducts(Program.dataProduct);
            }
        }

        private void tb_serch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tb_serch.Text;
            string searchQuery = "";

            if (cb_filter.SelectedItem == null)
            {
                searchQuery = $"{query} WHERE TRUE AND p.title ILIKE '%{searchText}%' GROUP BY p.id, p.title, pt.title, p.articlenumber, p.description, " +
                      $"p.image, p.productionpersoncount, p.productionworkshopnumber, p.mincostforagent";
            }
            else
            {
                searchQuery = $"{query} WHERE pt.title = '{TypeTitle}' AND p.title ILIKE '%{searchText}%' GROUP BY p.id, p.title, pt.title, p.articlenumber, p.description, " +
                              $"p.image, p.productionpersoncount, p.productionworkshopnumber, p.mincostforagent";
            }
                ClearPanel(panel_ListProducts);
                LoadProducts(searchQuery);
        }
    }
}

