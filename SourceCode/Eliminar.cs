namespace SourceCode
{
    public static class Eliminar
    {
        static Eliminar()
        {
            
        }

        public static void eliminarDB(string type, int id)
        {
            string sql = "";
            if (type.Equals("Business"))
            {
                sql = $"DELETE FROM BUSINESS WHERE idBusiness = {id}";  
            }
            else if (type.Equals("Product"))
            {
                sql = $"DELETE FROM PRODUCT WHERE idProduct = {id}";
            }
            else if (type.Equals("User"))
            {
                sql = $"DELETE FROM APPUSER WHERE idUser = {id}";
            }
            ConnectionDB.realizarAccion(sql);
        }
    }
}