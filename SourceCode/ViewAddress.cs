using System;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ViewAddress : UserControl
    {
        private int IdUser = 0;
        public ViewAddress(User u)
        {
            IdUser = u.idUser;
            InitializeComponent();
        }

        private void ViewAddress_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = $"SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = {IdUser}";
                DataTable dt = ConnectionDB.realizarConsulta(sql);
                dataGridViewAddress.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}