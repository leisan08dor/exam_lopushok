namespace Lopushok
{
    partial class ProductCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureProductBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ArticleLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureProductBox
            // 
            this.PictureProductBox.Location = new System.Drawing.Point(12, 14);
            this.PictureProductBox.Name = "PictureProductBox";
            this.PictureProductBox.Size = new System.Drawing.Size(171, 121);
            this.PictureProductBox.TabIndex = 0;
            this.PictureProductBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(206, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(356, 42);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Тип продукта | Наименование продукта";
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArticleLabel.Location = new System.Drawing.Point(206, 56);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(86, 42);
            this.ArticleLabel.TabIndex = 4;
            this.ArticleLabel.Text = "Артикул";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialLabel.Location = new System.Drawing.Point(206, 93);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(112, 42);
            this.MaterialLabel.TabIndex = 5;
            this.MaterialLabel.Text = "Материалы:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(823, 14);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(107, 42);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Стоимость";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.ArticleLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PictureProductBox);
            this.Location = new System.Drawing.Point(40, 0);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(960, 140);
            this.Load += new System.EventHandler(this.ProductCard_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductCard_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureProductBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ArticleLabel;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label PriceLabel;
    }
}
