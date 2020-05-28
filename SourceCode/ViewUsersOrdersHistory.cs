using System;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ViewUsersOrdersHistory : UserControl
    {
        public ViewUsersOrdersHistory()
        {
            InitializeComponent();
        }

        private void ViewUsersOrdersHistory_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser";
                DataTable dt = ConnectionDB.realizarConsulta(sql);
                dataGridViewUsersOrdersHistory.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}