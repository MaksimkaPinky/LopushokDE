
namespace Лопушок
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.NameFormLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.sortCB = new System.Windows.Forms.ComboBox();
            this.filtrCB = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DescendCB = new System.Windows.Forms.CheckBox();
            this.flowproductListpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.TopPanel.Controls.Add(this.NameFormLabel);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 100);
            this.TopPanel.TabIndex = 0;
            // 
            // NameFormLabel
            // 
            this.NameFormLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameFormLabel.AutoSize = true;
            this.NameFormLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFormLabel.Location = new System.Drawing.Point(312, 26);
            this.NameFormLabel.Name = "NameFormLabel";
            this.NameFormLabel.Size = new System.Drawing.Size(202, 50);
            this.NameFormLabel.TabIndex = 1;
            this.NameFormLabel.Text = "Список продукции";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Лопушок.Properties.Resources.Лопушок;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.BottomPanel.Controls.Add(this.AddButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 350);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 100);
            this.BottomPanel.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(3, 22);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(241, 57);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить продукцию";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.Location = new System.Drawing.Point(3, 103);
            this.searchTB.MaximumSize = new System.Drawing.Size(400, 40);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(250, 40);
            this.searchTB.TabIndex = 2;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // sortCB
            // 
            this.sortCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortCB.FormattingEnabled = true;
            this.sortCB.Items.AddRange(new object[] {
            "Наименование",
            "Номер производственного цеха",
            "Минимальная стоимость для агента"});
            this.sortCB.Location = new System.Drawing.Point(369, 100);
            this.sortCB.MaximumSize = new System.Drawing.Size(300, 0);
            this.sortCB.Name = "sortCB";
            this.sortCB.Size = new System.Drawing.Size(173, 43);
            this.sortCB.TabIndex = 3;
            this.sortCB.SelectedIndexChanged += new System.EventHandler(this.sortCB_SelectedIndexChanged);
            // 
            // filtrCB
            // 
            this.filtrCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filtrCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductTypeID", true));
            this.filtrCB.DataSource = this.productTypeBindingSource;
            this.filtrCB.DisplayMember = "Title";
            this.filtrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrCB.FormattingEnabled = true;
            this.filtrCB.Location = new System.Drawing.Point(620, 103);
            this.filtrCB.Name = "filtrCB";
            this.filtrCB.Size = new System.Drawing.Size(168, 43);
            this.filtrCB.TabIndex = 3;
            this.filtrCB.ValueMember = "ID";
            this.filtrCB.SelectedIndexChanged += new System.EventHandler(this.filtrCB_SelectedIndexChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Лопушок.EF.Product);
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(Лопушок.EF.ProductType);
            // 
            // DescendCB
            // 
            this.DescendCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescendCB.AutoSize = true;
            this.DescendCB.Location = new System.Drawing.Point(548, 117);
            this.DescendCB.Name = "DescendCB";
            this.DescendCB.Size = new System.Drawing.Size(15, 14);
            this.DescendCB.TabIndex = 4;
            this.DescendCB.UseVisualStyleBackColor = true;
            this.DescendCB.CheckedChanged += new System.EventHandler(this.DescendCB_CheckedChanged);
            // 
            // flowproductListpanel
            // 
            this.flowproductListpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowproductListpanel.AutoScroll = true;
            this.flowproductListpanel.Location = new System.Drawing.Point(3, 149);
            this.flowproductListpanel.Name = "flowproductListpanel";
            this.flowproductListpanel.Size = new System.Drawing.Size(797, 195);
            this.flowproductListpanel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowproductListpanel);
            this.Controls.Add(this.DescendCB);
            this.Controls.Add(this.filtrCB);
            this.Controls.Add(this.sortCB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label NameFormLabel;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.ComboBox sortCB;
        private System.Windows.Forms.ComboBox filtrCB;
        private System.Windows.Forms.CheckBox DescendCB;
        private System.Windows.Forms.FlowLayoutPanel flowproductListpanel;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.Button AddButton;
    }
}

