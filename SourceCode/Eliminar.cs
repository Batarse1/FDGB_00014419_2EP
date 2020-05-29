using System;

namespace SourceCode
{
    public static class Eliminar
    {
        static Eliminar()
        {
            
        }

        public static void eliminarDB(string type,string type_id, int id)
        {
            string sql = $"DELETE FROM {type} WHERE {type_id} = {id}";
            ConnectionDB.realizarAccion(sql);
        }
    }
}