﻿namespace SourceCode
{
    public class User
    {
        public int idUser { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool usertype {get; set;}

        public User()
        {
            idUser = 0;
            fullname = "";
            username = "";
            password = "";
            usertype = false;
        }
    }
}