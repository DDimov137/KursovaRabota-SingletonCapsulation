using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public String name { get; set; }
        public String password { get; set; }
        public String facNum { get; set; }
        public UserRoles role { get; set; }

        public DateTime created { get; set; }
        public DateTime valid { get; set; }
        public System.Int32 UserId { get; set; }

        public User(String name, String password, String facNum, UserRoles role)
        {
            this.name = name;
            this.password = password;
            this.facNum = facNum;
            this.role = role;
        }
    }
}
