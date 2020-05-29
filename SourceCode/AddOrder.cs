using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddOrder : UserControl
    {
        private int IdUser = 0;
        public AddOrder(User u)
        {
            IdUser = u.idUser;
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            try{
                string sql = "SELECT * FROM PRODUCT";
                DataTable dt = ConnectionDB.realizarConsulta(sql);
                Console.WriteLine(dt);
                List<Product> lista = new List<Product>();
                foreach (DataRow row in dt.Rows)
                {
                    Product p = new Product();
                    p.idProduct = Convert.ToInt32(row[0].ToString());
                    p.idBusiness = Convert.ToInt32(row[1].ToString());
                    p.name = row[2].ToString();
                    lista.Add(p);
                }

                comboBoxProducts.ValueMember = "idProduct";
                comboBoxProducts.DisplayMember = "name";
                comboBoxProducts.DataSource = lista;
            
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
                comboBoxDirection.ValueMember = "idAddress";
                comboBoxDirection.DisplayMember = "Address";
                comboBoxDirection.DataSource = list;
            }
            catch(Exception){
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        private void btnAddProductDB_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO APPORDER(createDate, idProduct, idAddress) VALUES('{DateTime.Now}', {comboBoxProducts.SelectedValue}, {comboBoxDirection.SelectedValue})";
                ConnectionDB.realizarAccion(sql);
                MessageBox.Show("Se a agregado exitosamente la orden");                
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }    
        }
    }
}