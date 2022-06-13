using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лопушок.Utils;
using Лопушок.EF;

namespace Лопушок.Views
{
    public partial class AddEditForms : Form
    {
        Product producto = new Product();
        internal Product prd;

        public AddEditForms()
        {
            InitializeComponent();
        }

        private void PicBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = Environment.CurrentDirectory + @"\products\";
            OFD.Filter = "png files (*.png)|*.png|All Files (*.*)|*.*";

            DialogResult DR = OFD.ShowDialog();

            if (DR == DialogResult.OK)
            {
                string file = OFD.FileName;
                int num = file.IndexOf("products");
                file = file.Substring(num);
                PBphoto.Image = Image.FromFile(file);
                producto.Image = file;
                
            }
        }            //if (producto == null)
                     //{
                     //    productBindingSource.AddNew();
                     //}
                     //else 
                     //{
                     //    productBindingSource.Add(producto);
                     //}
                     //StringBuilder errors = new StringBuilder();
                     //if (string.IsNullOrWhiteSpace(producto.ArticleNumber))
                     //{
                     //    errors.AppendLine("Укажите номер артикля");
                     //}
                     //if (string.IsNullOrWhiteSpace(producto.Title))
                     //{
                     //    errors.AppendLine("Укажите наименование");
                     //}
                     //if (string.IsNullOrWhiteSpace(producto.MinCostForAgent.ToString()))
                     //{
                     //    errors.AppendLine("Укажите минимальную цену для агента");
                     //}

        private void saveBut_Click(object sender, EventArgs e)
        {
            
            producto.ArticleNumber = articleNumberTextBox.Text;
            producto.Title = titleTextBox.Text;
            producto.ProductTypeID = productTypeIDComboBox.SelectedIndex + 1;
            producto.ProductionPersonCount = Convert.ToInt32(productionPersonCountTextBox.Text);
            producto.ProductionWorkshopNumber = Convert.ToInt32(productionWorkshopNumberTextBox.Text);
            producto.MinCostForAgent = Convert.ToDecimal(minCostForAgentTextBox.Text);
            producto.Description = descriptionTextBox.Text;

            if(producto.ID==0)
            { 
                DataBaseContext.db.Product.Add(producto); 
            }

            try
            {
                DataBaseContext.db.SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
        }

        private void AddEditForms_Load(object sender, EventArgs e)
        {
            productTypeBindingSource.DataSource = DataBaseContext.db.ProductType.ToList();
            productBindingSource.DataSource = DataBaseContext.db.Product.ToList();
            foreach (ProductCard prod in MainForm.selecredProdCard)
            {
                productBindingSource.DataSource = producto;
                PBphoto.ImageLocation = producto.Image;
            }
        }
    }
}
