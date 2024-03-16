namespace Lopushok
{
    partial class Form2_Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Products));
            this.panel_ListProducts = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_serch = new System.Windows.Forms.TextBox();
            this.cb_sort = new System.Windows.Forms.ComboBox();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ListProducts
            // 
            this.panel_ListProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ListProducts.AutoScroll = true;
            this.panel_ListProducts.Location = new System.Drawing.Point(-1, 81);
            this.panel_ListProducts.Name = "panel_ListProducts";
            this.panel_ListProducts.Size = new System.Drawing.Size(1052, 480);
            this.panel_ListProducts.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(991, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tb_serch
            // 
            this.tb_serch.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_serch.Location = new System.Drawing.Point(50, 13);
            this.tb_serch.Name = "tb_serch";
            this.tb_serch.Size = new System.Drawing.Size(365, 47);
            this.tb_serch.TabIndex = 9;
            this.tb_serch.Text = "Введите для поиска ...";
            this.tb_serch.TextChanged += new System.EventHandler(this.tb_serch_TextChanged);
            // 
            // cb_sort
            // 
            this.cb_sort.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.cb_sort.FormattingEnabled = true;
            this.cb_sort.Location = new System.Drawing.Point(489, 13);
            this.cb_sort.Name = "cb_sort";
            this.cb_sort.Size = new System.Drawing.Size(227, 50);
            this.cb_sort.TabIndex = 2;
            this.cb_sort.SelectedIndexChanged += new System.EventHandler(this.cb_sort_SelectedIndexChanged);
            // 
            // cb_filter
            // 
            this.cb_filter.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Location = new System.Drawing.Point(745, 13);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(221, 50);
            this.cb_filter.TabIndex = 3;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // Form2_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 603);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.cb_sort);
            this.Controls.Add(this.tb_serch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_ListProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2_Products";
            this.Text = "Каталог продукции";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_Products_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ListProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_serch;
        private System.Windows.Forms.ComboBox cb_sort;
        private System.Windows.Forms.ComboBox cb_filter;
    }
}