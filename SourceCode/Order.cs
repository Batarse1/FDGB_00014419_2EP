using System;

namespace SourceCode
{
    public class Order
    {
        public int idOrder { get; set; }
        public DateTime createDate { get; set; }
        public int idProduct { get; set; }
        public int idAddress { get; set; }

        public Order()
        {
            idOrder = 0;
            createDate = DateTime.Now;
            idProduct = 0;
            idAddress = 0;
        }
    }
}