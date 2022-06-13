using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лопушок.EF;
using Лопушок.Utils;

namespace Лопушок
{
    public partial class ProductCard : UserControl
    {
        public int ID;
        public delegate void MyHandler(string message, int id);
        public event MyHandler Notify;
        public ProductCard()
        {
            InitializeComponent();
        }
        public void GenerateDataToProductCard(Product product)
        {
            Photo.ImageLocation = product.Image;
            NameAndTypeProduct.Text = product.Title;
            ArticleLabel.Text = product.ArticleNumber;
            MaterialLabel.Text = product.ProductMaterial.ToString();
        }

        private void ProductCard_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {   //  если нажата левая кнопка мыши
                //  вызываем срабатывание события в котором передаем,
                //  1) нажата левая кнопка мыши и 2) ID элемента управления
                if (Notify != null) Notify("Левая кнопка", ID);
            }
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
    }
}
