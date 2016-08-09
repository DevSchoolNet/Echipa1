using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicatie
{
    public class User
    {
        public int idUser;
        public String userName;
        public String password;
        
        public User(int id, String user, String pass)
        {
            this.idUser = id;
            this.userName = user;

            this.password = pass;
        }
        public User() {
        }
        
    }
}
