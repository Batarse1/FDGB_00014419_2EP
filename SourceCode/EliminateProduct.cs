﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class EliminateProduct : UserControl
    {
        public EliminateProduct()
        {
            InitializeComponent();
        }

        private void btnEliminateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar.eliminarDB("PRODUCT","idProduct",Convert.ToInt32(comboBoxProducts.SelectedValue));
                MessageBox.Show("Producto eliminado exitosamente");
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        
        private void EliminateProduct_Load(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}