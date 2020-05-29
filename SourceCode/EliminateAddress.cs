using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class EliminateAddress : UserControl
    {
        private int IdUser =0;
        public EliminateAddress(User u)
        {
            IdUser = u.idUser;
            InitializeComponent();
        }

        private void btnEliminateAddress_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar.eliminarDB("ADDRESS","idAddress",Convert.ToInt32(comboBoxAddress.SelectedValue));
                MessageBox.Show("Direccion eliminada exitosamente");
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void EliminateAddress_Load(object sender, EventArgs e)
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
                comboBoxAddress.ValueMember = "idAddress";
                comboBoxAddress.DisplayMember = "Address";
                comboBoxAddress.DataSource = list;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}