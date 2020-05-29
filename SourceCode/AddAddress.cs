using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddAddress : UserControl
    {
        private int IdUser = 0;
        public AddAddress(User u)
        {
            IdUser = u.idUser;
            InitializeComponent();
        }

        private void btnEliminateAddress_Click(object sender, EventArgs e)
        {
            if (txtBoxAddress.Equals(""))
            {
                MessageBox.Show("Debe de ingresar información en todos los campos");
            }
            else
            {
                try
                {
                    string sql = $"INSERT INTO ADDRESS(idUser, address) VALUES({IdUser}, '{txtBoxAddress.Text}')";
                    ConnectionDB.realizarAccion(sql);
                    MessageBox.Show("Dirección añadida exitosamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}