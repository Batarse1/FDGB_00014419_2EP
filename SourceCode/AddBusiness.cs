using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddBusiness : UserControl
    {
        public AddBusiness()
        {
            InitializeComponent();
        }

        private void btnAddBusinessDB_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text.Equals("") || txtBoxDescription.Text.Equals(""))
            {
                MessageBox.Show("Debe de ingresar información en todos los campos");
            }
            else
            {
                try
                {
                    AddBusinessVerification(txtBoxName.Text, txtBoxDescription.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        void AddBusinessVerification(String name, String description)
        {
            string sql = $"INSERT INTO BUSINESS(name, description) VALUES ('{name}', '{description}')";
            ConnectionDB.realizarAccion(sql);
            MessageBox.Show("Negocio añadido exitosamente");
        }
    }
}