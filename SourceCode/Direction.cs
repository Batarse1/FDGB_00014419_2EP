namespace SourceCode
{
    public class Direction
    {
        public int idAddress { get; set; }
        public int idUser { get; set; }
        public string Address { get; set; }

        public Direction()
        {
            idAddress = 0;
            idUser = 0;
            Address = "";
        }
    }
}