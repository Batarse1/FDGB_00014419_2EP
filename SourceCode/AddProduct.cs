using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddProduct : UserControl
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAddProductDB_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text.Equals(""))
            {
                MessageBox.Show("Debe de ingresar información en todos los campos");
            }
            else
            {
                try
                {
                    string sql = $"INSERT INTO PRODUCT(idBusiness, name) VALUES({comboBoxBusiness.SelectedValue}, '{txtBoxName.Text}')";
                    ConnectionDB.realizarAccion(sql);
                }
                catch(Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM BUSINESS";
            
            DataTable dt = ConnectionDB.realizarConsulta(sql);
            
            List<Business> lista = new List<Business>();
            
            foreach (DataRow row in dt.Rows)
            {
                Business b = new Business();
                b.idBusiness = Convert.ToInt32(row[0].ToString());
                b.name = row[1].ToString();
                b.description = row[2].ToString();
                lista.Add(b);
            }

            comboBoxBusiness.ValueMember = "idBusiness";
            comboBoxBusiness.DisplayMember = "name";
            comboBoxBusiness.DataSource = lista;
        }
    }
}