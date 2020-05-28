using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Login : Form
    {
        private List<User> lista = new List<User>();
        public Login()
        {
            InitializeList();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text.Equals("") || txtBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe de ingresar información en todos los campos");
            }
            else
            {
                try
                {
                    LoginVerification(txtBoxName.Text,txtBoxPassword.Text);                   
                }
                catch(Exception){
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
        
        private void InitializeList(){
            string sql = "SELECT * FROM APPUSER";
            DataTable dt = ConnectionDB.realizarConsulta(sql);
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
        }
        
        private void LoginVerification(String a, String b)
        {
            bool usernameVerification = false;
            bool passwordVerification = false;
            foreach(User u in lista){
                if(u.username.Equals(a)){
                    usernameVerification = true;
                    if(u.password.Equals(b)){
                        passwordVerification = true;
                        MessageBox.Show("Iniciando Sesión...");
                        if(u.usertype){
                            Admin Window = new Admin(u);
                            Window.Show();
                            this.Hide(); 
                        }
                        else{
                            CommonUser Window = new CommonUser(u);
                            Window.Show();
                            this.Hide(); 
                        }
                    }
                }
            }

            if (usernameVerification && passwordVerification)
            {
            }
            else if (!usernameVerification)
            {
                MessageBox.Show("Nombre de usuario inexistente");
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }
    }
}