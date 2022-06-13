
namespace Лопушок
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
            this.Photo = new System.Windows.Forms.PictureBox();
            this.NameAndTypeProduct = new System.Windows.Forms.Label();
            this.ArticleLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.Image = global::Лопушок.Properties.Resources.picture;
            this.Photo.Location = new System.Drawing.Point(3, 3);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(168, 144);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 0;
            this.Photo.TabStop = false;
            // 
            // NameAndTypeProduct
            // 
            this.NameAndTypeProduct.AutoSize = true;
            this.NameAndTypeProduct.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAndTypeProduct.Location = new System.Drawing.Point(189, 18);
            this.NameAndTypeProduct.Name = "NameAndTypeProduct";
            this.NameAndTypeProduct.Size = new System.Drawing.Size(298, 39);
            this.NameAndTypeProduct.TabIndex = 1;
            this.NameAndTypeProduct.Text = "Тип продукта | Наименование продукта";
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArticleLabel.Location = new System.Drawing.Point(189, 53);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(79, 39);
            this.ArticleLabel.TabIndex = 1;
            this.ArticleLabel.Text = "Артикул";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialLabel.Location = new System.Drawing.Point(189, 88);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(100, 39);
            this.MaterialLabel.TabIndex = 1;
            this.MaterialLabel.Text = "Материалы";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(736, 18);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(97, 39);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Стоимость";
            // 
            // ProductCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ArticleLabel);
            this.Controls.Add(this.NameAndTypeProduct);
            this.Controls.Add(this.Photo);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(849, 148);
            this.Load += new System.EventHandler(this.ProductCard_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductCard_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Label NameAndTypeProduct;
        private System.Windows.Forms.Label ArticleLabel;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label CostLabel;
    }
}
