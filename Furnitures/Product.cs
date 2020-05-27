using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furnitures
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            ShowProduct();
        }

        void ShowProduct()
        {
            listViewProduct.Items.Clear();

            foreach (ProductSet product in Program.furn.ProductSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        product.Type, product.Material,product.Length.ToString(),product.Width.ToString(),
                        product.Height.ToString(), product.Price.ToString()
                });
                item.Tag = product;
                listViewProduct.Items.Add(item);
            }
            listViewProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 1)
            {
                ProductSet product = listViewProduct.SelectedItems[0].Tag as ProductSet;

                textBoxType.Text = product.Type;
                textBoxMaterial.Text = product.Material;
                textBoxHeight.Text = product.Height.ToString();
                textBoxWidth.Text = product.Width.ToString();
                textBoxLength.Text = product.Length.ToString();
                textBoxPrice.Text = product.Price.ToString();
            }
            else
            {
                textBoxType.Text = "";
                textBoxMaterial.Text = "";
                textBoxLength.Text = "";
                textBoxWidth.Text = "";
                textBoxHeight.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProductSet product = new ProductSet();

                product.Type = textBoxType.Text;
                product.Material = textBoxMaterial.Text;
                if (textBoxLength.Text != "")
                {
                    product.Length = Convert.ToDouble(textBoxLength.Text);
                }
                if (textBoxWidth.Text != "")
                {
                    product.Width = Convert.ToDouble(textBoxWidth.Text);
                }
                if (textBoxHeight.Text != "")
                {
                    product.Height = Convert.ToDouble(textBoxHeight.Text);
                }
                if (textBoxPrice.Text != "")
                {
                    product.Price = Convert.ToInt64(textBoxPrice.Text);
                }
                if (product.Type == "" || product.Material == "")
                {
                    throw new Exception("Обязательное заполнение полей!");
                }
                Program.furn.ProductSet.Add(product);
                Program.furn.SaveChanges();
                ShowProduct();
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    ProductSet product = listViewProduct.SelectedItems[0].Tag as ProductSet;
                    product.Type = textBoxType.Text;
                    product.Material = textBoxMaterial.Text;

                    if (textBoxLength.Text != "")
                    {
                        product.Length = Convert.ToDouble(textBoxLength.Text);
                    }
                    if (textBoxWidth.Text != "")
                    {
                        product.Width = Convert.ToDouble(textBoxWidth.Text);
                    }
                    if (textBoxHeight.Text != "")
                    {
                        product.Height = Convert.ToDouble(textBoxHeight.Text);
                    }
                    if (textBoxPrice.Text != "")
                    {
                        product.Price = Convert.ToInt64(textBoxPrice.Text);
                    }
                    if (product.Type == "" || product.Material == "")
                    {
                        throw new Exception("Обязательное заполнение полей!");
                    }
                    Program.furn.SaveChanges();
                    ShowProduct();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {

                if (listViewProduct.SelectedItems.Count == 1)
                {
                    ProductSet product = listViewProduct.SelectedItems[0].Tag as ProductSet;
                    Program.furn.ProductSet.Remove(product);
                    Program.furn.SaveChanges();
                    ShowProduct();
                }

                textBoxType.Text = "";
                textBoxMaterial.Text = "";
                textBoxLength.Text = "";
                textBoxWidth.Text = "";
                textBoxHeight.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
    }
}
