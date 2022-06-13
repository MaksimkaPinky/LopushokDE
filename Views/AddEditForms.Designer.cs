
namespace Лопушок.Views
{
    partial class AddEditForms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label articleNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.Windows.Forms.Label titleLabel;
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleNumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.minCostForAgentTextBox = new System.Windows.Forms.TextBox();
            this.productionPersonCountTextBox = new System.Windows.Forms.TextBox();
            this.productionWorkshopNumberTextBox = new System.Windows.Forms.TextBox();
            this.productTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.PBphoto = new System.Windows.Forms.PictureBox();
            this.PicBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            articleNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            productionPersonCountLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            productTypeIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // articleNumberLabel
            // 
            articleNumberLabel.AutoSize = true;
            articleNumberLabel.Location = new System.Drawing.Point(204, 21);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new System.Drawing.Size(73, 35);
            articleNumberLabel.TabIndex = 1;
            articleNumberLabel.Text = "Артикул:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(131, 294);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(146, 35);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Подробное описание:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Location = new System.Drawing.Point(29, 245);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(248, 35);
            minCostForAgentLabel.TabIndex = 7;
            minCostForAgentLabel.Text = "Минимальная стоимость для агента:";
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.Location = new System.Drawing.Point(24, 160);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(257, 35);
            productionPersonCountLabel.TabIndex = 9;
            productionPersonCountLabel.Text = "Количество человек для производства:";
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(61, 201);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(216, 35);
            productionWorkshopNumberLabel.TabIndex = 11;
            productionWorkshopNumberLabel.Text = "Номер производственного цеха:";
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.Location = new System.Drawing.Point(174, 111);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(103, 35);
            productTypeIDLabel.TabIndex = 13;
            productTypeIDLabel.Text = "Тип продукта:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(171, 65);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(110, 35);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Наименование:";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Лопушок.EF.Product);
            // 
            // articleNumberTextBox
            // 
            this.articleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ArticleNumber", true));
            this.articleNumberTextBox.Location = new System.Drawing.Point(283, 16);
            this.articleNumberTextBox.Name = "articleNumberTextBox";
            this.articleNumberTextBox.Size = new System.Drawing.Size(121, 40);
            this.articleNumberTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(283, 291);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(121, 38);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // minCostForAgentTextBox
            // 
            this.minCostForAgentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MinCostForAgent", true));
            this.minCostForAgentTextBox.Location = new System.Drawing.Point(283, 245);
            this.minCostForAgentTextBox.Name = "minCostForAgentTextBox";
            this.minCostForAgentTextBox.Size = new System.Drawing.Size(121, 40);
            this.minCostForAgentTextBox.TabIndex = 8;
            // 
            // productionPersonCountTextBox
            // 
            this.productionPersonCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionPersonCount", true));
            this.productionPersonCountTextBox.Location = new System.Drawing.Point(283, 157);
            this.productionPersonCountTextBox.Name = "productionPersonCountTextBox";
            this.productionPersonCountTextBox.Size = new System.Drawing.Size(121, 40);
            this.productionPersonCountTextBox.TabIndex = 10;
            // 
            // productionWorkshopNumberTextBox
            // 
            this.productionWorkshopNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionWorkshopNumber", true));
            this.productionWorkshopNumberTextBox.Location = new System.Drawing.Point(283, 201);
            this.productionWorkshopNumberTextBox.Name = "productionWorkshopNumberTextBox";
            this.productionWorkshopNumberTextBox.Size = new System.Drawing.Size(121, 40);
            this.productionWorkshopNumberTextBox.TabIndex = 12;
            // 
            // productTypeIDComboBox
            // 
            this.productTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductTypeID", true));
            this.productTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductTypeID", true));
            this.productTypeIDComboBox.DataSource = this.productTypeBindingSource;
            this.productTypeIDComboBox.DisplayMember = "Title";
            this.productTypeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeIDComboBox.FormattingEnabled = true;
            this.productTypeIDComboBox.Location = new System.Drawing.Point(283, 108);
            this.productTypeIDComboBox.Name = "productTypeIDComboBox";
            this.productTypeIDComboBox.Size = new System.Drawing.Size(121, 43);
            this.productTypeIDComboBox.TabIndex = 14;
            this.productTypeIDComboBox.ValueMember = "ID";
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(Лопушок.EF.ProductType);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(283, 62);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(121, 40);
            this.titleTextBox.TabIndex = 16;
            // 
            // PBphoto
            // 
            this.PBphoto.Image = global::Лопушок.Properties.Resources.picture;
            this.PBphoto.Location = new System.Drawing.Point(550, 16);
            this.PBphoto.Name = "PBphoto";
            this.PBphoto.Size = new System.Drawing.Size(215, 203);
            this.PBphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBphoto.TabIndex = 17;
            this.PBphoto.TabStop = false;
            // 
            // PicBut
            // 
            this.PicBut.Location = new System.Drawing.Point(550, 245);
            this.PicBut.Name = "PicBut";
            this.PicBut.Size = new System.Drawing.Size(208, 50);
            this.PicBut.TabIndex = 18;
            this.PicBut.Text = "Выбрать фото";
            this.PicBut.UseVisualStyleBackColor = true;
            this.PicBut.Click += new System.EventHandler(this.PicBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(196, 366);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(208, 50);
            this.saveBut.TabIndex = 18;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // AddEditForms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.PicBut);
            this.Controls.Add(this.PBphoto);
            this.Controls.Add(articleNumberLabel);
            this.Controls.Add(this.articleNumberTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.minCostForAgentTextBox);
            this.Controls.Add(productionPersonCountLabel);
            this.Controls.Add(this.productionPersonCountTextBox);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(this.productionWorkshopNumberTextBox);
            this.Controls.Add(productTypeIDLabel);
            this.Controls.Add(this.productTypeIDComboBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AddEditForms";
            this.Text = "AddEditForms";
            this.Load += new System.EventHandler(this.AddEditForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox articleNumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox minCostForAgentTextBox;
        private System.Windows.Forms.TextBox productionPersonCountTextBox;
        private System.Windows.Forms.TextBox productionWorkshopNumberTextBox;
        private System.Windows.Forms.ComboBox productTypeIDComboBox;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.PictureBox PBphoto;
        private System.Windows.Forms.Button PicBut;
        private System.Windows.Forms.Button saveBut;
    }
}