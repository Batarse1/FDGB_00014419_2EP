using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class CommonUser : Form
    {
        private UserControl current = null;
        private User ActualUser = null;
        public CommonUser(User u)
        {
            ActualUser = u;
            InitializeComponent();
            InitializeUserControl();
        }

        private void InitializeUserControl()
        {
            tableLayoutPanelCommonUser.Controls.Remove(current);
            current = new ManageUserOrders(ActualUser);
            current.Dock = DockStyle.Fill;
            tableLayoutPanelCommonUser.Controls.Add(current, 0,1);
            tableLayoutPanelCommonUser.SetColumnSpan(current, 2);
        }
        
        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!(current is ManageUserOrders))
            {
                tableLayoutPanelCommonUser.Controls.Remove(current);
                current = new ManageUserOrders(ActualUser);
                current.Dock = DockStyle.Fill;
                tableLayoutPanelCommonUser.Controls.Add(current, 0,1);
                tableLayoutPanelCommonUser.SetColumnSpan(current, 2);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (!(current is ManageAddress))
            {
                tableLayoutPanelCommonUser.Controls.Remove(current);
                current = new ManageAddress(ActualUser);
                current.Dock = DockStyle.Fill;
                tableLayoutPanelCommonUser.Controls.Add(current, 0,1);
                tableLayoutPanelCommonUser.SetColumnSpan(current, 2);
            }
        }

        private void CommonUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}