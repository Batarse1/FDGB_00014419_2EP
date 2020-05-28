using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class EliminateUser : UserControl
    {
        
        public EliminateUser()
        {
            InitializeComponent();
        }

        private void btnEliminateUser_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar.eliminarDB("User",Convert.ToInt32(comboBoxUsers.SelectedValue));
                MessageBox.Show("Usuario eliminado exitosamente");
            }
            catch(Exception)
            {
                throw new IdException("Ha ocurrido un error");
            }
        }

        private void EliminateUser_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM APPUSER";
            DataTable dt = ConnectionDB.realizarConsulta(sql);
            Console.WriteLine(dt);
            List<User> lista = new List<User>();
            foreach (DataRow row in dt.Rows)
            {
                User u = new User();
                u.idUser = Convert.ToInt32(row[0].ToString());
                u.fullname = row[1].ToString();
                u.username = row[2].ToString();
                u.password = row[3].ToString();
                u.usertype = Convert.ToBoolean(row[4].ToString());
                lista.Add(u);
            }

            comboBoxUsers.ValueMember = "idUser";
            comboBoxUsers.DisplayMember = "username";
            comboBoxUsers.DataSource = lista;
        }
    }
}