using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lopushok
{
    public partial class ProductCard : UserControl
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ProductTypeID { get; set; }
        public string MinCostForAgent { get; set; }
        public string ArticleNumber { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public string ImageProduct { get; set; }
        public string ProductionPersonCount { get; set; }
        public string ProductionWorkshopNumber { get; set; }
        
        public ProductCard()
        {
            InitializeComponent();
        }

        public Product Product { get; set; }

        private void ProductCard_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            Id = Product.Id.ToString();
            Title = Product.Title.ToString();
            ArticleNumber = Product.ArticleNumber.ToString();
            ProductTypeID = Product.ProductType.ToString();
            Material = string.Join(", ", Product.Material);
            Description = Product.Description.ToString();
            ImageProduct = Product.Image.ToString();
            MinCostForAgent = Product.MinCostForAgent.ToString();
            ProductionPersonCount = Product.ProductionPersonCount.ToString();
            ProductionWorkshopNumber = Product.ProductionWorkshopNumber.ToString();

            // Привязка данных из объекта Product к элементам управления на контроле

            NameLabel.Text = ProductTypeID + " | "+ Title;
            PriceLabel.Text = MinCostForAgent;
            ArticleLabel.Text = ArticleLabel.Text+" "+ArticleNumber;
            MaterialLabel.Text = MaterialLabel.Text+" "+Material;
            PictureProductBox.Image = Image.FromFile(Product.Image);
            PictureProductBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }


        public void ProductCard_MouseClick(object sender, MouseEventArgs e)
        {
            Form3_ProductCard newForm = new Form3_ProductCard(Id,Title, ProductTypeID, MinCostForAgent, ArticleNumber, Description, ImageProduct, ProductionPersonCount, ProductionWorkshopNumber); // создание новой формы
            newForm.Show();

        }
    }
}
