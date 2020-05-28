using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddOrder : UserControl
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
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
                Direction d = new Direction();
                d.idAddress = Convert.ToInt32(row[0].ToString());
                d.idUser = Convert.ToInt32(row[1].ToString());
                d.Address = row[2].ToString();
                list.Add(d);
            }

            comboBoxDirection.ValueMember = "idAddress";
            comboBoxDirection.DisplayMember = "Address";
            comboBoxDirection.DataSource = list;
        }
    }
}