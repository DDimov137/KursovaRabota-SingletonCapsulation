using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
        private static List<User> _testUsers;
        public static List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }

        public static void setUserActiveTo(String name, DateTime newTime)
        {
            foreach(User user in _testUsers)
            {
                if (name.Equals(user.name))
                {
                    user.valid = newTime;
                    Logger.logActivity("Промяна на активност на " + user.name);
                }
            }
        }

        public static void assignUserRole(String name,UserRoles role)
        {
            foreach (User user in _testUsers)
            {
                if (name.Equals(user.name))
                {
                    user.role = role;
                    Logger.logActivity("Промяна на роля на " + user.name);
                }
            }
        }

        public static User IsUserPassCorrect(String password,String name)
        {
            /*foreach(User user1 in TestUsers)
            {
                if (user1.name.Equals(name) && user1.password.Equals(password))
                {
                    return user1;
                }
            }*/
            User user = (from use in _testUsers where name.Equals(use.name) && password.Equals(use.password) select use).First();
            return null;
        }

        public static void ResetTestUserData()
        {
            if(_testUsers == null)
            {
                _testUsers.Add(new User("name1", "password1", "facNum1", (UserRoles)2));
                _testUsers.Add(new User("name2", "password2", "facNum2", (UserRoles)4));
                _testUsers.Add(new User("name3", "password3", "facNum3", (UserRoles)4));
                _testUsers[0].created = DateTime.Today;
                _testUsers[1].created = DateTime.Today;
                _testUsers[2].created = DateTime.Today;
                _testUsers[0].valid = DateTime.MaxValue;
                _testUsers[1].valid = DateTime.MaxValue;
                _testUsers[2].valid = DateTime.MaxValue;
            }
        }
    }
}
