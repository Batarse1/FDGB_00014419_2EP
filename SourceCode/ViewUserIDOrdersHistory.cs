using System;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ViewUserIDOrdersHistory : UserControl
    {
        private int IdUser = 0;
        public ViewUserIDOrdersHistory(User u)
        {
            IdUser = u.idUser;
            InitializeComponent();
        }

        private void ViewUserIDOrdersHistory_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser AND au.idUser = {IdUser}";
                DataTable dt = ConnectionDB.realizarConsulta(sql);
                dataGridViewUserOrders.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}