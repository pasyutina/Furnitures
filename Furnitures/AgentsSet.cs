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
    public partial class AgentsSet : Form
    {
        public AgentsSet()
        {
            InitializeComponent();
            ShowAgent();
        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                textBoxFirstName.Text = agentSet.FirstName;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxLastName.Text = agentSet.LastName;
                textBoxPhone.Text = agentSet.Phone;
                textBoxDeal.Text = agentSet.DealShare.ToString();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxDeal.Text = "";
            }
        }
        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (AgentSet agentSet in Program.furn.AgentSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    agentSet.FirstName, agentSet.LastName, agentSet.MiddleName,  agentSet.Phone, agentSet.DealShare.ToString()
                });
                item.Tag = agentSet;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AgentSet agentSet = new AgentSet();
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.Phone = textBoxPhone.Text;
                if (textBoxDeal.Text != "")
                {
                    agentSet.DealShare = Convert.ToInt32(textBoxDeal.Text);
                }
                if (agentSet.FirstName == "" || agentSet.MiddleName == "" || agentSet.LastName == "")
                {
                    throw new Exception("Обязательное заполнение полей ФИО!");
                }
                if (agentSet.DealShare < 0 || agentSet.DealShare > 100)
                {
                    throw new Exception("Доля от комиссии должна находиться в диапазоне от 0 до 100!");
                }
                Program.furn.AgentSet.Add(agentSet);
                Program.furn.SaveChanges();
                ShowAgent();
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
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                    agentSet.FirstName = textBoxFirstName.Text;
                    agentSet.MiddleName = textBoxMiddleName.Text;
                    agentSet.LastName = textBoxLastName.Text;
                    agentSet.Phone = textBoxPhone.Text;
                    if (textBoxDeal.Text != "")
                    {
                        agentSet.DealShare = Convert.ToInt32(textBoxDeal.Text);
                    }
                    if (agentSet.FirstName == "" || agentSet.MiddleName == "" || agentSet.LastName == "")
                    {
                        throw new Exception("Обязательное заполнение полей ФИО!");
                    }
                    if (agentSet.DealShare < 0 || agentSet.DealShare > 100)
                    {
                        throw new Exception("Доля от комиссии должна находиться в диапазоне от 0 до 100!");
                    }
                    Program.furn.SaveChanges();
                    ShowAgent();
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
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                    Program.furn.AgentSet.Remove(agentSet);
                    Program.furn.SaveChanges();
                    ShowAgent();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxDeal.Text = "";
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

        private void textBoxDeal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
