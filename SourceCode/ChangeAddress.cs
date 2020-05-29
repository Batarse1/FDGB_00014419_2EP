using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ChangeAddress : UserControl
    {
        int IdUser = 0;
        public ChangeAddress(User u)
        {
            IdUser = u.idUser;
            InitializeComponent();
        }

        private void ChangeAddress_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlAddress = "SELECT * FROM ADDRESS";
                DataTable dtAux = ConnectionDB.realizarConsulta(sqlAddress);
                Console.WriteLine(dtAux);
                List<Direction> list = new List<Direction>();
                foreach (DataRow row in dtAux.Rows)
                {
                    if (IdUser == Convert.ToInt32(row[1].ToString()))
                    {
                        Direction d = new Direction();
                        d.idAddress = Convert.ToInt32(row[0].ToString());
                        d.idUser = Convert.ToInt32(row[1].ToString());
                        d.Address = row[2].ToString();
                        list.Add(d);
                    }
                }
                comboBoxOldAddress.ValueMember = "idAddress";
                comboBoxOldAddress.DisplayMember = "Address";
                comboBoxOldAddress.DataSource = list;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnChangeAddress_Click(object sender, EventArgs e)
        {
            try{
                string sql = $"UPDATE ADDRESS SET address = '{textBoxNewAddress.Text}' WHERE idAddress = {comboBoxOldAddress.SelectedValue}";
                ConnectionDB.realizarAccion(sql);
                MessageBox.Show("Dirección actualizada exitosamente");
            }
            catch(Exception){
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}