using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        private String name { get; set; }
        public delegate void ActionOnError(string ERROR);
        private String password { get; set; }
        public String ERROR;
        private ActionOnError actErr;
        public LoginValidation(String name,String password,ActionOnError actErr)
        {
            this.name = name;
            this.password = password;
            this.actErr = actErr;
        }

        
        
        public static UserRoles currentUserRole { get; private set; }
        public static String currentUser { get; private set; }
        public bool ValidateUserInput(User user)
        {
            bool emptyName = this.name.Equals(String.Empty);
            if (emptyName)
            {
                this.ERROR = "Не е посочено потребителско име";
                //Console.WriteLine(ERROR);
                this.actErr(ERROR);
                currentUserRole = (UserRoles)1;
                return false;
            }

            if(this.name.Length < 5 || this.password.Length < 5)
            {
                this.ERROR = "Password of Username too short";
                //Console.WriteLine(ERROR);
                this.actErr(ERROR);
                currentUserRole = (UserRoles)1;
                return false;
            }

            bool emptyPassword = this.name.Equals(String.Empty);
            if (emptyPassword)
            {
                this.ERROR = "Не е посочено потребителска парола";
                //Console.WriteLine(ERROR);
                this.actErr(ERROR);
                currentUserRole = (UserRoles)1;
                return false;
            }

            User use = UserData.IsUserPassCorrect(this.password, this.name);
            if(use == null)
            {
                ERROR = "Грешно име или парола!";
                //Console.WriteLine(ERROR);
                this.actErr(ERROR);
                currentUserRole = (UserRoles)1;
                return false;
            }
            Logger.logActivity("Успешен Login");
            user.name = use.name;
            user.password = use.password;
            user.facNum = use.facNum;
            user.role = use.role;
            currentUserRole = (UserRoles)use.role;
            currentUser = user.name;
            return true;
        }
    }
}
