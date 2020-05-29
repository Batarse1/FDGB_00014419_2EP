using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class EliminateOrder : UserControl
    {
        private int IdUser = 0;
        public EliminateOrder(User u)
        {
            IdUser = u.idUser;
            InitializeComponent();
        }
        
        private void btnEliminateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.realizarAccion($"DELETE FROM APPORDER WHERE idOrder = {comboBoxOrders.SelectedValue}");
                MessageBox.Show("Orden eliminada exitosamente");
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        
        private void EliminateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlD = "SELECT * FROM ADDRESS";
                DataTable dtD = ConnectionDB.realizarConsulta(sqlD);
                List<Direction> directions = new List<Direction>();
                foreach (DataRow row in dtD.Rows)
                {
                    if (IdUser == Convert.ToInt32(row[1].ToString()))
                    {
                        Direction d = new Direction();
                        d.idAddress = Convert.ToInt32(row[0].ToString());
                        d.idUser = Convert.ToInt32(row[1].ToString());
                        d.Address = row[2].ToString();
                        directions.Add(d);
                    }
                }
            
                string sql = "SELECT * FROM APPORDER";
                DataTable dt = ConnectionDB.realizarConsulta(sql);
                Console.WriteLine(dt);
                List<Order> lista = new List<Order>();
                foreach (DataRow row in dt.Rows)
                {
                    foreach (Direction direction in directions)
                    {
                        if (direction.idAddress == Convert.ToInt32(row[3].ToString()))
                        {
                            Order o = new Order();
                            o.idOrder = Convert.ToInt32(row[0].ToString());
                            o.createDate = Convert.ToDateTime(row[1].ToString());
                            o.idProduct = Convert.ToInt32(row[2].ToString());
                            o.idAddress = Convert.ToInt32(row[3].ToString());
                            lista.Add(o);
                        }
                    }
                }
                comboBoxOrders.ValueMember = "idOrder";
                comboBoxOrders.DisplayMember = "idOrder";
                comboBoxOrders.DataSource = lista;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}