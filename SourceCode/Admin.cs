using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Admin : Form
    {
        private UserControl current = null;
        public Admin(User u)
        {
            InitializeComponent();
            current = manageUsers1;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!(current is ManageUsers))
            {
                tableLayoutPanelAdmin.Controls.Remove(current);
                current = new ManageUsers();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelAdmin.Controls.Add(current, 0,1);
                tableLayoutPanelAdmin.SetColumnSpan(current, 4);
            }
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            if (!(current is ManageBusiness))
            {
                tableLayoutPanelAdmin.Controls.Remove(current);
                current = new ManageBusiness();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelAdmin.Controls.Add(current, 0,1);
                tableLayoutPanelAdmin.SetColumnSpan(current, 4);
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (!(current is ManageProducts))
            {
                tableLayoutPanelAdmin.Controls.Remove(current);
                current = new ManageProducts();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelAdmin.Controls.Add(current, 0,1);
                tableLayoutPanelAdmin.SetColumnSpan(current, 4);
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (!(current is ViewUsersOrdersHistory))
            {
                tableLayoutPanelAdmin.Controls.Remove(current);
                current = new ViewUsersOrdersHistory();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelAdmin.Controls.Add(current, 0,1);
                tableLayoutPanelAdmin.SetColumnSpan(current, 4);
            }
        }
        
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}