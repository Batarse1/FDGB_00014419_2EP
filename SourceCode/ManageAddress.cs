using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ManageAddress : UserControl
    {
        private UserControl current = null;
        private User ActualUser = null;
        public ManageAddress(User u)
        {
            ActualUser = u;
            InitializeComponent();
            InitializeUserControl();
        }

        private void InitializeUserControl()
        {
            tableLayoutPanelAddress.Controls.Remove(current);
            current = new AddAddress(ActualUser);
            current.Dock = DockStyle.Fill;
            tableLayoutPanelAddress.Controls.Add(current, 0,1);
            tableLayoutPanelAddress.SetColumnSpan(current, 4);
        }
        
        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if (!(current is AddAddress))
            {
                tableLayoutPanelAddress.Controls.Remove(current);
                current = new AddAddress(ActualUser);
                current.Dock = DockStyle.Fill;
                tableLayoutPanelAddress.Controls.Add(current, 0,1);
                tableLayoutPanelAddress.SetColumnSpan(current, 4);
            }
        }

        private void btnEliminateAddress_Click(object sender, EventArgs e)
        {
            if (!(current is EliminateAddress))
            {
                tableLayoutPanelAddress.Controls.Remove(current);
                current = new EliminateAddress(ActualUser);
                current.Dock = DockStyle.Fill;
                tableLayoutPanelAddress.Controls.Add(current, 0,1);
                tableLayoutPanelAddress.SetColumnSpan(current, 4);
            }
        }

        private void btnViewAddress_Click(object sender, EventArgs e)
        {
            if (!(current is ViewAddress))
            {
                tableLayoutPanelAddress.Controls.Remove(current);
                current = new ViewAddress(ActualUser);
                current.Dock = DockStyle.Fill;
                tableLayoutPanelAddress.Controls.Add(current, 0,1);
                tableLayoutPanelAddress.SetColumnSpan(current, 4);
            }
        }

        private void btnChangeAddress_Click(object sender, EventArgs e)
        {
            if (!(current is ChangeAddress))
            {
                tableLayoutPanelAddress.Controls.Remove(current);
                current = new ChangeAddress(ActualUser);
                current.Dock = DockStyle.Fill;
                tableLayoutPanelAddress.Controls.Add(current, 0,1);
                tableLayoutPanelAddress.SetColumnSpan(current, 4);
            }
        }
    }
}