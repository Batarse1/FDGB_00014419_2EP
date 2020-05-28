using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace SourceCode
{
    public partial class EliminateBusiness : UserControl
    {
        public EliminateBusiness()
        {
            InitializeComponent();
        }

        private void btnEliminateBusiness_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar.eliminarDB("Business",Convert.ToInt32(comboBoxBusiness.SelectedValue));
                MessageBox.Show("Producto eliminado exitosamente");
            }
            catch(Exception)
            {
                throw new IdException("Ha ocurrido un error");
            }
        }


        private void EliminateBusiness_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM BUSINESS";
            DataTable dt = ConnectionDB.realizarConsulta(sql);
            Console.WriteLine(dt);
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