using System;
using System.Windows.Forms;
using CoffeeShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeShop
{
    public partial class frmMain : Form
    {
        private Shop _coffeeShop;


        public frmMain()
        {
            InitializeComponent();

            this._coffeeShop = new Shop();
            this._coffeeShop.CategoryList = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Image = "img1",
                    IsNew = true,
                    Name = "Cafea boabe"
                },
                new Category()
                {
                    Id = 2,
                    Image = "img2",
                    IsNew = false,
                    Name = "Cafea macinata"
                },
                new Category()
                {
                    Id = 3,
                    Image = "img3",
                    IsNew = true,
                    Name = "Capsule"
                },
                new Category()
                {
                    Id = 4,
                    Image = "img4",
                    IsNew = false,
                    Name = "Cafea bio"
                },
                new Category()
                {
                    Id = 5,
                    Image = "img5",
                    IsNew = false,
                    Name = "Cafea instant"
                },
            };

            this._coffeeShop.ProductList = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Image = "img1",
                    CategoryId = 1,
                    Name = "Exklusive Edle boabe 250G",
                    FullPrice = new Money(14.50, "RON"),
                    Quantity = 50,
                    WeightInGrams = 250
                },
                new Product()
                {
                    Id = 2,
                    Image = "img2",
                    CategoryId = 1,
                    Name = "Exklusive Krafting Boabe 250G",
                    FullPrice = new Money(15.50, "RON"),
                    Quantity = 100,
                    WeightInGrams = 250
                },
                new Product()
                {
                    Id = 3,
                    Image = "img3",
                    CategoryId = 1,
                    Name = "Movenpick Espresso boabe 250g",
                    FullPrice = new Money(15, "RON"),
                    Quantity = 75,
                    WeightInGrams = 250
                },
                new Product()
                {
                    Id = 4,
                    Image = "img4",
                    CategoryId = 4,
                    Name = "Cafes Richard Bolivie Boabe 250G",
                    FullPrice = new Money(37.39, "RON"),
                    Quantity = 50,
                    WeightInGrams = 250
                },
                new Product()
                {
                    Id = 5,
                    Image = "img5",
                    CategoryId = 4,
                    Name = "Cafes Richard Terroirs D'Afrique Gurunsi Bio Boabe 1KG",
                    FullPrice = new Money(100.50, "RON"),
                    Quantity = 50,
                    WeightInGrams = 1000
                }
            };
        }

        #region "TOP MENU EVENTS"

        #region "TS FILE MENU EVENTS"
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void newShopTsItem_Click(object sender, EventArgs e)
        {

        }

        private void openShopTsItem_Click(object sender, EventArgs e)
        {

        }

        private void saveShopTsItem_Click(object sender, EventArgs e)
        {

        }

        private void saveShopAsTsItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region "TS EDIT MENU EVENTS"
        private void addProductTsItem_Click(object sender, EventArgs e)
        {

        }

        private void addCategoryTsItem_Click(object sender, EventArgs e)
        {
            var frmAddCateg = new frmAddCategory();
            frmAddCateg.ShowDialog();
        }
        #endregion

        #region "TS SETTINGS MENU EVENTS"
        private void tsSettingsMenu_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region "TS HELP MENU EVENTS"
        private void aboutTsItem_Click(object sender, EventArgs e)
        {

        }

        private void helpTsItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (var category in this._coffeeShop.CategoryList)
            {
                var lvItem = new ListViewItem();
                lvItem.SubItems.Add(category.Id.ToString());
                lvItem.SubItems.Add(category.Name);
                lvItem.SubItems.Add(this._coffeeShop.ProductList.Count(p => p.CategoryId == category.Id).ToString());

                this.categoryListView.Items.Add(lvItem);
            }
        }

        private void categoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstructProductList();
        }

        private void ConstructProductList()
        {
            this.dgvProducts.Rows.Clear();

            if (this.categoryListView.SelectedIndices?.Count > 0)
            {
                foreach (var product in this._coffeeShop.ProductList.FindAll(p => p.CategoryId == this._coffeeShop.CategoryList[this.categoryListView.SelectedIndices[0]].Id))
                {
                    var dgvRow = this.dgvProducts.Rows[this.dgvProducts.Rows.Add()];
                    dgvRow.Cells["colId"].Value = product.Id;
                    dgvRow.Cells["colName"].Value = product.Name;
                    dgvRow.Cells["colPrice"].Value = product.FullPrice.GetFormattedValue();
                    dgvRow.Cells["colNewPrice"].Value = product.ReducedPrice?.GetFormattedValue();
                    dgvRow.Cells["colQty"].Value = product.Quantity;
                    dgvRow.Cells["colDetails"].Value = "...";
                    dgvRow.Cells["colEdit"].Value = "EDIT";
                    dgvRow.Cells["colDelete"].Value = "DELETE";

                }
            }
        }
    }
}
