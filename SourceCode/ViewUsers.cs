using System;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ViewUsers : UserControl
    {
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM APPUSER";
                DataTable dt = ConnectionDB.realizarConsulta(sql);
                dataGridViewUsers.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}