using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lopushok
{
    public partial class Form3_ProductCard : Form
    {

        public int id {get; set;}
        public string title { get; set; }
        public string description { get; set; }
        public string productType { get; set; }
        public decimal minCostForAgent { get; set; }
        public string articleNumber { get; set; }
        public string image { get; set; }
        public int productionPersonCount { get; set; }
        public int productionWorkshopNumber { get; set; }
        public string ImageProduct {  get; set; }

        public Form3_ProductCard(string Id, string Title, string ProductType, string MinCostForAgent, string ArticleNumber, string Description,
            string ImageProduct, string ProductionPersonCount, string ProductionWorkshopNumber)
        {
            InitializeComponent();

            this.ImageProduct = ImageProduct;
            this.id = Convert.ToInt32(Id);
            tb_title.Text = Title;
            tb_type.Text = ProductType;
            tb_MinCost.Text = MinCostForAgent;
            tb_article.Text = ArticleNumber;
            tb_describe.Text = Description;
            PictureProductBox.Image = System.Drawing.Image.FromFile(ImageProduct);
            tb_CountPeople.Text = ProductionPersonCount;
            tb_shop.Text = ProductionWorkshopNumber;

            id = Convert.ToInt32(Id);
            title = tb_title.Text;
            productType = tb_type.Text;
            minCostForAgent = Convert.ToDecimal(MinCostForAgent);
            articleNumber = tb_article.Text;
            description = tb_describe.Text;
            PictureProductBox.Tag = PictureProductBox.Image;
            image = ImageProduct;
            productionPersonCount = Convert.ToInt32(ProductionPersonCount);
            productionWorkshopNumber = Convert.ToInt32(ProductionWorkshopNumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool deleted = Program.DeleteProduct(id);

            if (deleted)
            {
                MessageBox.Show("Продукт был успешно удален.");
                this.Close();
                Form2_Products form2 = System.Windows.Forms.Application.OpenForms.OfType<Form2_Products>().FirstOrDefault();
                if (form2 != null)
                {
                    form2.LoadProducts(Program.dataProduct); // Вызываем метод LoadProducts() на существующей форме 2
                }
            }
            else
            {
                MessageBox.Show("Не удалось удалить продукт или удаление было отменено.");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_title.Text = title;
            tb_type.Text = productType;
            tb_MinCost.Text = Convert.ToString(minCostForAgent);
            tb_article.Text = articleNumber;
            tb_describe.Text = description;
            PictureProductBox.Image = (System.Drawing.Image)PictureProductBox.Tag;
            tb_CountPeople.Text = Convert.ToString(productionPersonCount);
            tb_shop.Text = Convert.ToString(productionWorkshopNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            title = tb_title.Text;
            productType = tb_type.Text;
            minCostForAgent = Convert.ToDecimal(tb_MinCost.Text);
            articleNumber = tb_article.Text;
            description = tb_describe.Text;
            image = @"\products\" + Path.GetFileName(ImageProduct);
            productionPersonCount = Convert.ToInt32(tb_CountPeople.Text);
            productionWorkshopNumber = Convert.ToInt32(tb_shop.Text);  
            

            bool success = Program.UpdateProduct(id, title, productType, articleNumber,
                                              description, image, productionPersonCount, productionWorkshopNumber, minCostForAgent);

            if (success)
            {
                MessageBox.Show("Данные успешно обновлены в базе данных.");
                this.Close();
                Form2_Products form2 = System.Windows.Forms.Application.OpenForms.OfType<Form2_Products>().FirstOrDefault();
                if (form2 != null)
                {
                    form2.LoadProducts(Program.dataProduct); // Вызываем метод LoadProducts() на существующей форме 2
                }
            }
            else
            {
                MessageBox.Show("Не удалось обновить данные в базе данных.");
            }
        }

        private void btn_EditImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                string destinationFolderPath = @"E:\STUDY\4 КУРС\2 СЕМЕСТР\Промежуточный экзамен\Промежуточный контроль\Сессия 1\products";
                try
                {
                    string imageName = Path.GetFileName(selectedImagePath);
                    string destinationImagePath = Path.Combine(destinationFolderPath, imageName);
                    File.Copy(selectedImagePath, destinationImagePath, true);
                    ImageProduct = destinationImagePath;
                    PictureProductBox.Image = System.Drawing.Image.FromFile(ImageProduct);

                    MessageBox.Show("Картинка успешно загружена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке картинки: " + ex.Message);
                }
            }
        }




        //----------------------------------------------------------------------------------
        private void tb_article_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = System.Drawing.Color.FromArgb(0x00, 0xCC, 0x76);

        }

        private void tb_type_KeyDown(object sender, KeyEventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            textBox.BackColor = System.Drawing.Color.FromArgb(0x00, 0xCC, 0x76);
        }

        private void tb_CountPeople_KeyDown(object sender, KeyEventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            textBox.BackColor = System.Drawing.Color.FromArgb(0x00, 0xCC, 0x76);
        }

        private void tb_title_KeyDown(object sender, KeyEventArgs e)
       {

            TextBox textBox = (TextBox)sender;
            textBox.BackColor = System.Drawing.Color.FromArgb(0x00, 0xCC, 0x76);
        }

        private void tb_shop_KeyDown(object sender, KeyEventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            textBox.BackColor = System.Drawing.Color.FromArgb(0x00, 0xCC, 0x76);
        }

        private void tb_describe_KeyDown(object sender, KeyEventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            textBox.BackColor = System.Drawing.Color.FromArgb(0x00, 0xCC, 0x76);
        }

        private void tb_MinCost_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = System.Drawing.Color.FromArgb(0x00, 0xCC, 0x76);
        }

       
    }
}
