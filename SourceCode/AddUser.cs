using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddUser : UserControl
    {
        private List<String> lista = new List<String>();
        public AddUser()
        {
            InitializeList();
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            comboBoxUserType.DataSource = lista;
        }

        private void InitializeList()
        {
            lista.Add("Usuario normal");
            lista.Add("Administrador");
        }

        private void btnAddUserDB_Click(object sender, EventArgs e)
        {
            if (txtBoxFullname.Text.Equals("") || txtBoxUsername.Text.Equals("") || txtBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe de ingresar información en todos los campos");
            }
            else
            {
                try
                {
                    if (verifyFullname(txtBoxFullname.Text))
                    {
                        throw new FullnameException("Debe de ingresar solo letras del alfabeto");
                    }

                    bool Usertype = false;
                    if (comboBoxUserType.Text.Equals("Administrador"))
                    {
                        Usertype = true;
                        AddUserVerification(txtBoxFullname.Text, txtBoxUsername.Text, txtBoxPassword.Text, Usertype);
                    }
                    else if (comboBoxUserType.Text.Equals("Usuario normal"))
                    {
                        AddUserVerification(txtBoxFullname.Text, txtBoxUsername.Text, txtBoxPassword.Text, Usertype);
                    }
                    else
                    {
                        MessageBox.Show("Debe de ingresar un tipo de usuario válido");
                    }
                }
                catch (FullnameException exc)
                {
                    MessageBox.Show(exc.Message);   
                }
                catch(Exception){
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void AddUserVerification(String fullname, String username, String password, bool userType)
        {
            try{
                string sql = $"INSERT INTO APPUSER(fullname, username, password, userType) VALUES('{fullname}', '{username}', '{password}', {userType})";
                ConnectionDB.realizarAccion(sql);
                MessageBox.Show("Usuario añadido exitosamente");
            }
            catch(Exception){
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        
        private bool verifyFullname(String a)
        {
            bool verifier = false;
            foreach (char c in a)
            {
                if (c>96 && c<123)
                {
                    
                }
                else if (c > 64 && c < 91)
                {
                    
                }
                else
                {
                    verifier = true;
                }
            }
            return verifier;
        }
    }
}