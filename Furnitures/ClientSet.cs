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
    public partial class ClientSet : Form
    {
        public ClientSet()
        {
            InitializeComponent();
            ShowClient();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxEmai.Text = clientSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmai.Text = "";
            }
        }

        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.furn.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        clientsSet.FirstName,  clientsSet.LastName, clientsSet.MiddleName, clientsSet.Phone, clientsSet.Email
                    });
                item.Tag = clientsSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClientsSet clientSet = new ClientsSet();
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Email = textBoxEmai.Text;
                if (clientSet.FirstName == "" || clientSet.MiddleName == "" || clientSet.LastName == "")
                {
                    throw new Exception("Обязательное заполнение полей ФИО!");
                }
                Program.furn.ClientsSet.Add(clientSet);
                Program.furn.SaveChanges();
                ShowClient();
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    clientSet.FirstName = textBoxFirstName.Text;
                    clientSet.MiddleName = textBoxMiddleName.Text;
                    clientSet.LastName = textBoxLastName.Text;
                    clientSet.Phone = textBoxPhone.Text;
                    clientSet.Email = textBoxEmai.Text;
                    if (clientSet.FirstName == "" || clientSet.MiddleName == "" || clientSet.LastName == "")
                    {
                        throw new Exception("Обязательное заполнение полей ФИО!");
                    }
                    Program.furn.SaveChanges();
                    ShowClient();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    Program.furn.ClientsSet.Remove(clientSet);
                    Program.furn.SaveChanges();
                    ShowClient();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmai.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
