using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Preparcial.Excepciones;

namespace Preparcial.Controlador
{
    public static class ControladorInventario
    {
        // Metodo encargado de devolver un DataTable con todos los elementos del inventario
        public static DataTable GetProductosTable()
        {
            DataTable productos = null;

            // Solamente la consulta y conexion a la BD van en el try, ya que lo demas no puede ocasionar excepcion
            try
            {
                productos = ConexionBD.EjecutarConsulta("SELECT * FROM INVENTARIO");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return productos;
        }

        // Metodo que devuelve los productos en formato de List
        public static List<Inventario> GetProductos()
        {
            // Declaracion de lista y DataTable
            var productos = new List<Inventario>();
            DataTable dt = null;

            try
            {
                // Consulta para llenar el DataTable
                dt = ConexionBD.EjecutarConsulta("SELECT * FROM INVENTARIO");

                // Por cada fila del DataTable, crear un nuevo usuario anadiendolo a la lista
                foreach(DataRow dr in dt.Rows)
                {
                    productos.Add(new Inventario
                        (
                            dr[0].ToString(),
                            dr[1].ToString(),
                            dr[2].ToString(),
                            dr[3].ToString(),
                            dr[4].ToString()
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return productos;
        }

        // Metodo para anadir productos
        public static void AnadirProducto(string nombre, string descripcion, string precio, string stock)
        {
            try
            {
                //verificar que sean no negativos
                if (0>Convert.ToDouble(precio) || Convert.ToInt32(stock)<0)
                {
                    throw new NonNegativeValueException("Debe de ingresar los datos correctos");
                }
                //Se cambia nombreArticulo por nombreArt debido a que en la base de datos se encuentra nombreArt, no nombreArticulo...
                ConexionBD.EjecutarComando("INSERT INTO INVENTARIO(nombreArt, descripcion, precio, stock)" +
                    $" VALUES('{nombre}', '{descripcion}', {precio}, {stock})");

                MessageBox.Show("Se ha agregado el producto");
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe de ingresar los campos en el formato correcto");
            }
            //Se debe de atrapar la excepción en caso se encuentre un negativo
            catch (NonNegativeValueException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        // Metodo para eliminar productos
        public static void EliminarProducto(string id)
        {
            try
            {
                //Se debe de verificar si es un número y si existe ese ID en INVENTARIO, en caso contrario se lanzan excepciones
                if (!VerifyId(Convert.ToInt32(id)))
                {
                    throw new IdException("Debe de ingresar un ID existente");
                }

                ConexionBD.EjecutarComando($"DELETE FROM INVENTARIO WHERE idArticulo = {id}");

                MessageBox.Show("Se ha eliminado el producto");
            }
            //Se debe de atrapar la excepción en caso no sea un número
            catch (FormatException)
            {
                MessageBox.Show("Debe de ingresar los campos en el formato correcto");
            }
            //Se debe de atrapar la excepción en caso no se encuentre en inventario el ID
            catch (IdException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        // Metodo para actualizar stock de un producto
        public static void ActualizarProducto(string id, string stock)
        {
            try
            {
                //Debe de verificarse que sea un no negativo
                if (Convert.ToInt32(stock) < 0)
                {
                    throw new NonNegativeValueException("Debe de ingresar los datos correctos");
                }

                //Se debe de verificar si es un número y si existe ese ID en INVENTARIO, en caso contrario se lanzan excepciones
                if (!VerifyId(Convert.ToInt32(id)))
                {
                    throw new IdException("Debe de ingresar un ID existente");
                }

                Convert.ToInt32(stock);
                ConexionBD.EjecutarComando($"UPDATE INVENTARIO SET stock = {stock} WHERE idArticulo = {id}");

                MessageBox.Show("Se ha actualizado el producto");
            }
            //Se debe de atrapar la excepción en caso no sea un número
            catch (FormatException)
            {
                MessageBox.Show("Debe de ingresar los campos en el formato correcto");
            }
            //Se debe de atrapar la excepción en caso se encuentre un negativo
            catch (NonNegativeValueException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Se debe de atrapar la excepción en caso no se encuentre en inventario el ID
            catch (IdException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        //Se crea una función estática para poder verificar si se encuentra en INVENTARIO (si se encuentra retorna verdadero)
        private static bool VerifyId(int a)
        {
            foreach (var inv in GetProductos())
            {
                if (inv.GetProductId() == a)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
