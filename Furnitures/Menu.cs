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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Authorization.users.Type == "agent") buttonAgents.Enabled = false;
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form clientSet = new ClientSet();
            clientSet.Show();
        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            Form agentSet = new AgentsSet();
            agentSet.Show();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Form product = new Product();
            product.Show();
        }

        private void buttonZakaz_Click(object sender, EventArgs e)
        {
            Form zakaz = new Zakaz();
            zakaz.Show();
        }
    }
}
