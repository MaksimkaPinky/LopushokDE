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
using Лопушок.Views;

namespace Лопушок
{
    public partial class MainForm : Form
    {
        public List<Product> products = new List<Product>(DataBaseContext.db.Product);
        public static List<ProductCard> selecredProdCard = new List<ProductCard>();
        static int nProdInPage = 20;
        public MainForm()
        {
            InitializeComponent();
            GenerateProductCardList(products);
        }

        private void GenerateProductCardList(List<Product> products)
        {
            foreach(var p in products)
            {
                ProductCard card = new ProductCard();
                card.GenerateDataToProductCard(p);
                flowproductListpanel.Controls.Add(card);
            }
        }
        private void Notify(string message, int id)
        {
            if (message == "Левая кнопка")
            {
                AddEditForms addedd = new AddEditForms();
                Product prd = products.Find(p => p.ID == id);
                addedd.prd = prd;
                addedd.ShowDialog();
                SortListView();
            }
        }
        private void SortListView()
        {
            var listUpdate = DataBaseContext.db.Product.ToList();
            #region Фильтрация 
            if (filtrCB.SelectedIndex > 0)
            {
                listUpdate = listUpdate.Where(type => type.ProductType.Title == filtrCB.SelectedItem.ToString()).ToList();
            }
            #endregion
            #region Поиск
            if (searchTB.Text != "Введите для поиска")
            {
                listUpdate = listUpdate.Where(x => x.Title.ToLower().Contains(searchTB.Text.ToLower()) || x.Description.ToLower().Contains(searchTB.Text.ToLower())).ToList();
            }
            #endregion
            #region Сортировка
            if (sortCB.Text=="Наименование")
            {
                if (!DescendCB.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Title).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Title).ToList();
                }
            }
            if (sortCB.Text == "Номер производственного цеха")
            {
                if (!DescendCB.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.ProductionWorkshopNumber).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.ProductionWorkshopNumber).ToList();
                }
            }
            if (sortCB.Text == "Минимальная стоимость для агента")
            {
                if (!DescendCB.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.MinCostForAgent).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.MinCostForAgent).ToList();
                }
            }
            #endregion
            flowproductListpanel.Controls.Clear();
            GenerateProductCardList(listUpdate);
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if (searchTB.Text != "Введите для поиска")
            {
                flowproductListpanel.Controls.Clear();
                SortListView();
            }

        }

        private void sortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowproductListpanel.Controls.Clear();
            SortListView();

        }

        private void filtrCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowproductListpanel.Controls.Clear();
            SortListView();

        }

        private void DescendCB_CheckedChanged(object sender, EventArgs e)
        {
            flowproductListpanel.Controls.Clear();
            SortListView();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var allType = DataBaseContext.db.ProductType.Select(type => type.Title).ToList();
            allType.Insert(0, "Все типы");
            filtrCB.DataSource = allType;
            filtrCB.SelectedIndex = 0;
            sortCB.SelectedIndex = 0;
            for (int i = 0;i<nProdInPage;i++)
            {
                selecredProdCard.Add(new ProductCard());
                selecredProdCard[i].Notify += Notify;
                flowproductListpanel.Controls.Add(selecredProdCard[i]);
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEditForms addedd = new AddEditForms();
            addedd.ShowDialog();
            SortListView();
        }
    }
}
