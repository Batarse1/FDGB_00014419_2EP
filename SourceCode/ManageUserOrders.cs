using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ManageUserOrders : UserControl
    {
        private User ActualUser = null;
        private UserControl current = null;
        public ManageUserOrders(User u)
        {
            ActualUser = u;
            InitializeComponent();
            InitializeUserControl();
        }
        private void InitializeUserControl()
        {
            tableLayoutPanelUserOrders.Controls.Remove(current);
            current = new AddOrder(ActualUser);
            current.Dock = DockStyle.Fill;
            tableLayoutPanelUserOrders.Controls.Add(current, 0,1);
            tableLayoutPanelUserOrders.SetColumnSpan(current, 3);
        }

        private void btnAddUserOrder_Click(object sender, EventArgs e)
        {
            if (!(current is AddOrder))
            {
                tableLayoutPanelUserOrders.Controls.Remove(current);
                current = new AddOrder(ActualUser);
                current.Dock = DockStyle.Fill;
                tableLayoutPanelUserOrders.Controls.Add(current, 0,1);
                tableLayoutPanelUserOrders.SetColumnSpan(current, 3);
            }
        }

        private void btnEliminateUserOrder_Click(object sender, EventArgs e)
        {
            if (!(current is EliminateOrder))
            {
                tableLayoutPanelUserOrders.Controls.Remove(current);
                current = new EliminateOrder(ActualUser);
                current.Dock = DockStyle.Fill;
                tableLayoutPanelUserOrders.Controls.Add(current, 0,1);
                tableLayoutPanelUserOrders.SetColumnSpan(current, 3);
            }
        }

        private void btnViewUserOrders_Click(object sender, EventArgs e)
        {
            if (!(current is ViewUserIDOrdersHistory))
            {
                tableLayoutPanelUserOrders.Controls.Remove(current);
                current = new ViewUserIDOrdersHistory(ActualUser);
                current.Dock = DockStyle.Fill;
                tableLayoutPanelUserOrders.Controls.Add(current, 0,1);
                tableLayoutPanelUserOrders.SetColumnSpan(current, 3);
            }
        }
    }
}