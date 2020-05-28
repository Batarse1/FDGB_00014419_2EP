using System;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ViewUserIDOrdersHistory : UserControl
    {
        public ViewUserIDOrdersHistory()
        {
            InitializeComponent();
        }

        private void btnSearchUserOrders_Click(object sender, EventArgs e)
        {
            try
            {
                SearchVerification(txtBoxUserID.Text);
            }
            catch (IdException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        public void SearchVerification(String a)
        {
            try
            {
                int number = Convert.ToInt32(a);
                bool idExist = false;
                string sql = "SELECT idUser FROM APPUSER";
                DataTable dt = ConnectionDB.realizarConsulta(sql);
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt32(row[0].ToString()) == number)
                    {
                        string sqlSearch = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser AND au.idUser = {number}";
                        DataTable dtSearch = ConnectionDB.realizarConsulta(sqlSearch);
                        dataGridViewUserOrders.DataSource = dtSearch;
                        idExist = true;
                    }
                }
                if (!idExist)
                {
                    throw new IdException("Debe de ingresar un ID válido");
                }
            }
            catch (IdException exc)
            {
                throw new IdException(exc.Message);
            }
            catch (Exception)
            {
                throw new IdException("Debe de ingresar un número");
            }
        }
    }
}