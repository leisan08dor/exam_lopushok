namespace Lopushok
{
    partial class Form3_ProductCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_ProductCard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureProductBox = new System.Windows.Forms.PictureBox();
            this.lb_article = new System.Windows.Forms.Label();
            this.tb_article = new System.Windows.Forms.TextBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.lb_CountPeople = new System.Windows.Forms.Label();
            this.tb_CountPeople = new System.Windows.Forms.TextBox();
            this.lb_shop = new System.Windows.Forms.Label();
            this.tb_shop = new System.Windows.Forms.TextBox();
            this.lb_describe = new System.Windows.Forms.Label();
            this.tb_describe = new System.Windows.Forms.TextBox();
            this.btn_EditImage = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.lb_MinCost = new System.Windows.Forms.Label();
            this.tb_MinCost = new System.Windows.Forms.TextBox();
            this.bt_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductBox)).BeginInit();
            this.SuspendLayout();
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
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PictureProductBox
            // 
            this.PictureProductBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureProductBox.Location = new System.Drawing.Point(33, 35);
            this.PictureProductBox.Name = "PictureProductBox";
            this.PictureProductBox.Size = new System.Drawing.Size(230, 204);
            this.PictureProductBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureProductBox.TabIndex = 10;
            this.PictureProductBox.TabStop = false;
            // 
            // lb_article
            // 
            this.lb_article.AutoSize = true;
            this.lb_article.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_article.Location = new System.Drawing.Point(269, 35);
            this.lb_article.Name = "lb_article";
            this.lb_article.Size = new System.Drawing.Size(90, 42);
            this.lb_article.TabIndex = 14;
            this.lb_article.Text = "Артикул:";
            // 
            // tb_article
            // 
            this.tb_article.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tb_article.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_article.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_article.Location = new System.Drawing.Point(276, 90);
            this.tb_article.Name = "tb_article";
            this.tb_article.Size = new System.Drawing.Size(125, 40);
            this.tb_article.TabIndex = 13;
            this.tb_article.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_article_KeyDown);
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_type.Location = new System.Drawing.Point(489, 35);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(132, 42);
            this.lb_type.TabIndex = 16;
            this.lb_type.Text = "Тип продукции:";
            // 
            // tb_type
            // 
            this.tb_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tb_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_type.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_type.Location = new System.Drawing.Point(496, 90);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(158, 40);
            this.tb_type.TabIndex = 15;
            this.tb_type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_type_KeyDown);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_title.Location = new System.Drawing.Point(269, 197);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(132, 42);
            this.lb_title.TabIndex = 18;
            this.lb_title.Text = "Наименование:";
            // 
            // tb_title
            // 
            this.tb_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tb_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_title.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_title.Location = new System.Drawing.Point(276, 252);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(286, 40);
            this.tb_title.TabIndex = 17;
            this.tb_title.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_title_KeyDown);
            // 
            // lb_CountPeople
            // 
            this.lb_CountPeople.AutoSize = true;
            this.lb_CountPeople.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_CountPeople.Location = new System.Drawing.Point(835, 155);
            this.lb_CountPeople.Name = "lb_CountPeople";
            this.lb_CountPeople.Size = new System.Drawing.Size(154, 84);
            this.lb_CountPeople.TabIndex = 20;
            this.lb_CountPeople.Text = "Кол-во человек\r\nдля производства:";
            // 
            // tb_CountPeople
            // 
            this.tb_CountPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tb_CountPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CountPeople.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_CountPeople.Location = new System.Drawing.Point(907, 251);
            this.tb_CountPeople.Name = "tb_CountPeople";
            this.tb_CountPeople.Size = new System.Drawing.Size(82, 40);
            this.tb_CountPeople.TabIndex = 19;
            this.tb_CountPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_CountPeople.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_CountPeople_KeyDown);
            // 
            // lb_shop
            // 
            this.lb_shop.AutoSize = true;
            this.lb_shop.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_shop.Location = new System.Drawing.Point(835, 319);
            this.lb_shop.Name = "lb_shop";
            this.lb_shop.Size = new System.Drawing.Size(76, 42);
            this.lb_shop.TabIndex = 22;
            this.lb_shop.Text = "№ цеха:";
            // 
            // tb_shop
            // 
            this.tb_shop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tb_shop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_shop.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_shop.Location = new System.Drawing.Point(907, 364);
            this.tb_shop.Name = "tb_shop";
            this.tb_shop.Size = new System.Drawing.Size(82, 40);
            this.tb_shop.TabIndex = 21;
            this.tb_shop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_shop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_shop_KeyDown);
            // 
            // lb_describe
            // 
            this.lb_describe.AutoSize = true;
            this.lb_describe.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_describe.Location = new System.Drawing.Point(269, 309);
            this.lb_describe.Name = "lb_describe";
            this.lb_describe.Size = new System.Drawing.Size(95, 42);
            this.lb_describe.TabIndex = 24;
            this.lb_describe.Text = "Описание:";
            // 
            // tb_describe
            // 
            this.tb_describe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tb_describe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_describe.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_describe.Location = new System.Drawing.Point(276, 364);
            this.tb_describe.Multiline = true;
            this.tb_describe.Name = "tb_describe";
            this.tb_describe.Size = new System.Drawing.Size(523, 158);
            this.tb_describe.TabIndex = 23;
            this.tb_describe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_describe_KeyDown);
            // 
            // btn_EditImage
            // 
            this.btn_EditImage.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditImage.Location = new System.Drawing.Point(33, 252);
            this.btn_EditImage.Name = "btn_EditImage";
            this.btn_EditImage.Size = new System.Drawing.Size(230, 40);
            this.btn_EditImage.TabIndex = 25;
            this.btn_EditImage.Text = "Загрузить фото";
            this.btn_EditImage.UseVisualStyleBackColor = true;
            this.btn_EditImage.Click += new System.EventHandler(this.btn_EditImage_Click);
            // 
            // bt_save
            // 
            this.bt_save.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_save.Location = new System.Drawing.Point(877, 551);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(163, 40);
            this.bt_save.TabIndex = 26;
            this.bt_save.Text = "Сохранить";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_cancel.Location = new System.Drawing.Point(653, 551);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(163, 40);
            this.bt_cancel.TabIndex = 27;
            this.bt_cancel.Text = "Отменить";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_MinCost
            // 
            this.lb_MinCost.AutoSize = true;
            this.lb_MinCost.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_MinCost.Location = new System.Drawing.Point(595, 197);
            this.lb_MinCost.Name = "lb_MinCost";
            this.lb_MinCost.Size = new System.Drawing.Size(150, 42);
            this.lb_MinCost.TabIndex = 29;
            this.lb_MinCost.Text = "Мин. стоимость:";
            // 
            // tb_MinCost
            // 
            this.tb_MinCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tb_MinCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_MinCost.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_MinCost.Location = new System.Drawing.Point(602, 252);
            this.tb_MinCost.Name = "tb_MinCost";
            this.tb_MinCost.Size = new System.Drawing.Size(158, 40);
            this.tb_MinCost.TabIndex = 28;
            this.tb_MinCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_MinCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_MinCost_KeyDown);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_delete.Location = new System.Drawing.Point(805, 12);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(180, 40);
            this.bt_delete.TabIndex = 30;
            this.bt_delete.Text = "Удалить продукцию";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3_ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 603);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.lb_MinCost);
            this.Controls.Add(this.tb_MinCost);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.btn_EditImage);
            this.Controls.Add(this.lb_describe);
            this.Controls.Add(this.tb_describe);
            this.Controls.Add(this.lb_shop);
            this.Controls.Add(this.tb_shop);
            this.Controls.Add(this.lb_CountPeople);
            this.Controls.Add(this.tb_CountPeople);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.lb_article);
            this.Controls.Add(this.tb_article);
            this.Controls.Add(this.PictureProductBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Name = "Form3_ProductCard";
            this.Text = "Карточка продукции";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PictureProductBox;
        private System.Windows.Forms.Label lb_article;
        private System.Windows.Forms.TextBox tb_article;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label lb_CountPeople;
        private System.Windows.Forms.TextBox tb_CountPeople;
        private System.Windows.Forms.Label lb_shop;
        private System.Windows.Forms.TextBox tb_shop;
        private System.Windows.Forms.Label lb_describe;
        private System.Windows.Forms.TextBox tb_describe;
        private System.Windows.Forms.Button btn_EditImage;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label lb_MinCost;
        private System.Windows.Forms.TextBox tb_MinCost;
        private System.Windows.Forms.Button bt_delete;
    }
}