using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ManageProducts : UserControl
    {
        private UserControl current = null;
        public ManageProducts()
        {
            InitializeComponent();
            current = addProduct1;
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!(current is AddProduct))
            {
                tableLayoutPanelProduct.Controls.Remove(current);
                current = new AddProduct();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelProduct.Controls.Add(current, 0,1);
                tableLayoutPanelProduct.SetColumnSpan(current, 2);
            }
        }

        private void BtnEliminateProduct_Click(object sender, EventArgs e)
        {
            if (!(current is EliminateProduct))
            {
                tableLayoutPanelProduct.Controls.Remove(current);
                current = new EliminateProduct();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelProduct.Controls.Add(current, 0,1);
                tableLayoutPanelProduct.SetColumnSpan(current, 2);
            }
        }

    }
}