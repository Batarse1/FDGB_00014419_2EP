using System;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text.Equals("") || textBoxOldPassword.Text.Equals("") || textBoxNewPassword.Text.Equals("") || textBoxRepeatedNewPassword.Text.Equals("")){
                MessageBox.Show("Debe de ingresar información en todos los campos");
            }
            else{
                bool exist = false;
                string sql = "SELECT * FROM APPUSER";
                DataTable dt = ConnectionDB.realizarConsulta(sql);
                foreach (DataRow row in dt.Rows)
                {
                    if(textBoxUsername.Text.Equals(row[2].ToString())){
                        User u = new User();
                        u.idUser = Convert.ToInt32(row[0].ToString());
                        u.fullname = row[1].ToString();
                        u.username = row[2].ToString();
                        u.password = row[3].ToString();
                        u.usertype = Convert.ToBoolean(row[4].ToString());
                        if(textBoxNewPassword.Text.Equals(textBoxRepeatedNewPassword.Text)){
                            if(textBoxOldPassword.Text.Equals(u.password)){
                                string sqlPassword = $"UPDATE APPUSER SET password = '{textBoxNewPassword.Text}' WHERE idUser = {u.idUser}";
                                ConnectionDB.realizarAccion(sqlPassword);
                                MessageBox.Show("Se ha cambiado la contraseña exitosamente");                                                                
                            }
                            else
                            {
                                MessageBox.Show("Debe de ingresar la contraseña actual correctamente");                                
                            }
                        }
                        else{
                            MessageBox.Show("Debe de verificar que sean iguales los campos de nueva contraseña");
                        }
                        exist = true;
                    }
                }
                if (!exist)
                {
                    MessageBox.Show("Debe de ingresar un usuario válido");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login Window = new Login();
            Window.Show();
            this.Hide(); 
        }

        private void Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}