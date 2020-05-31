using Preparcial.Modelo;
using Preparcial.Controlador;
using System.Windows.Forms;
using System.Linq;
using System;

namespace Preparcial.Vista
{
    public partial class FrmMain : Form
    {
        private Usuario u;

        public FrmMain(Usuario u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void bttnCreateUser_Click(object sender, EventArgs e)
        {
            if (!txtNewUser.Text.Equals(""))
            {
                ControladorUsuario.CrearUsuario(txtNewUser.Text);
                ActualizarCrearUsuario();
            }
            //Se le agrega el else en caso este vacio
            else
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
        }

        private void ActualizarCrearUsuario()
        {
            dgvCreateUser.DataSource = ControladorUsuario.GetUsuariosTable();
        }

        private void ActualizarInventario()
        {
            dgvInventary.DataSource = ControladorInventario.GetProductosTable();
        }

        private void ActualizarOrdenes()
        {
            dgvAllOrders.DataSource = ControladorPedido.GetPedidosTable();
        }

        private void ActualizarOrdenesUsuario()
        {
            dgvMyOrders.DataSource = ControladorPedido.GetPedidosUsuarioTable(u.IdUsuario);
            //se inicializa en nulo
            // Metodo para poblar el comboBox con todos los productos, asignando el value member y display member desde
            // las PROPIEDADES de la clase Usuario, deben ser publicas y llamarse igual para que funcione, ademas
            // primero se asigna el ValueMember, luego DisplayMember, y por ultimo el DataSource, sino tira excepcion
            cmbProductMakeOrder.DataSource = null;
            cmbProductMakeOrder.ValueMember = "idArticulo";
            cmbProductMakeOrder.DisplayMember = "producto";
            cmbProductMakeOrder.DataSource = ControladorInventario.GetProductos();
        }

        private void bttnAddInventary_Click(object sender, EventArgs e)
        {
            //Se debe cambiar los && por || debido a que solo entraría al if en dado caso se dejen todos los campos vacíos, pero es necesario entrar en caso deje al menos uno, para lo cual nos beneficia el ||.
            if (txtProductNameInventary.Text.Equals("") ||
                txtDescriptionInventary.Text.Equals("") ||
                txtPriceInventary.Text.Equals("") ||
                txtStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.AnadirProducto(txtProductNameInventary.Text, txtDescriptionInventary.Text,
                    txtPriceInventary.Text, txtStockInventary.Text);

                ActualizarInventario();
            }
        }

        private void bttnDeleteInventary_Click(object sender, EventArgs e)
        {
            if(txtDeleteInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.EliminarProducto(txtDeleteInventary.Text);
                ActualizarInventario();
            }
        }
        
        private void bttnUpdateStockInventary_Click(object sender, EventArgs e)
        {
            //Se debe cambiar el && por || debido a que solo entraría al if en dado caso se dejen todos los campos vacíos, pero es necesario entrar en caso se deje al menos uno, para lo cual nos beneficia el ||.
            if (txtUpdateStockIdInventary.Text.Equals("") || txtUpdateStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.ActualizarProducto(txtUpdateStockIdInventary.Text, txtUpdateStockInventary.Text);
                ActualizarInventario();
            }
        }

        private void bttnMakeOrder_Click(object sender, EventArgs e)
        {
            if (txtMakeOrderQuantity.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorPedido.HacerPedido(u.IdUsuario, cmbProductMakeOrder.SelectedValue.ToString(), txtMakeOrderQuantity.Text);
                ActualizarOrdenesUsuario();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name.Equals("createNewUserTab") && u.Admin)
                ActualizarCrearUsuario();

            else if (tabControl1.SelectedTab.Name.Equals("inventaryTab") && u.Admin)
                //Se cambio el design de inventario ya que decia eliminar donde debía de decir actualizar
                ActualizarInventario();

            else if (tabControl1.SelectedTab.Name.Equals("createOrderTab") && !u.Admin)
                ActualizarOrdenesUsuario();

            else if (tabControl1.SelectedTab.Name.Equals("viewOrdersTab") && u.Admin)
                ActualizarOrdenes();
            
            //Añadir if para que no muestre mensaje de que no tiene permisos en la primera ventana
            else if(tabControl1.SelectedTab.Name.Equals("generalTab")) 
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            
            
            else
            {
                MessageBox.Show("No tiene permisos para ver esta pestaña");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
    Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ActualizarOrdenesUsuario();
        }
    }
}
