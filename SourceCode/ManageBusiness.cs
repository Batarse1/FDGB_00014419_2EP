using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ManageBusiness : UserControl
    {
        private UserControl current = null;
        public ManageBusiness()
        {
            InitializeComponent();
            current = addBusiness1;
        }


        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            if (!(current is AddBusiness))
            {
                tableLayoutPanelBusiness.Controls.Remove(current);
                current = new AddBusiness();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelBusiness.Controls.Add(current, 0,1);
                tableLayoutPanelBusiness.SetColumnSpan(current, 2);
            }
        }

        private void btnEliminateBusiness_Click(object sender, EventArgs e)
        {
            if (!(current is EliminateBusiness))
            {
                tableLayoutPanelBusiness.Controls.Remove(current);
                current = new EliminateBusiness();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelBusiness.Controls.Add(current, 0,1);
                tableLayoutPanelBusiness.SetColumnSpan(current, 2);
            }
        }
    }
}