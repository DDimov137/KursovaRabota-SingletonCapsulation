using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class Program
    {
        public static void dumbShit(String error)
        {
            Console.WriteLine("!!!" + error + "!!!");
        }
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            String password = Console.ReadLine();
            LoginValidation valid = new LoginValidation(name, password, dumbShit);

            
            User user1 = UserData.TestUsers[0];
            if (valid.ValidateUserInput(user1))
            {
                Console.WriteLine(user1.name);
                Console.WriteLine(user1.password);
                Console.WriteLine(user1.facNum);
                Console.WriteLine(user1.role);
                switch (LoginValidation.currentUserRole)
                {
                    case UserRoles.ANONYMOUS: Console.WriteLine("This man is anon!"); break;
                    case UserRoles.ADMIN: Console.WriteLine("This man is an admin!"); break;
                    case UserRoles.INSPECTOR: Console.WriteLine("This man is an inspector!"); break;
                    case UserRoles.PROFESSOR: Console.WriteLine("This man is a professor!"); break;
                    case UserRoles.STUDENT: Console.WriteLine("This man is a student!"); break;
                    default: Console.WriteLine("Wrong role idiot!");break;
                }
                while (true) {
                    Console.WriteLine("Изберете опция:" +
                        "\n0:Изход" +
                        "\n1:Промяна на дата на активност" +
                        "\n2:Промяна на роля" +
                        "\n3:Списък на потребители" +
                        "\n4:Покажи лог на потребителите" +
                        "\n5:Покажи сегашни промени");
                    String option = Console.ReadLine();
                    switch (option)
                    {
                        case "0":break;
                        case "1":
                            Console.WriteLine("Name: ");
                            String swtichName = Console.ReadLine();
                            Console.WriteLine("New Date: ");
                            DateTime switchDate = DateTime.Parse(Console.ReadLine());
                            UserData.setUserActiveTo(swtichName, switchDate);
                            break;
                        case "2":
                            Console.WriteLine("Name: ");
                            String swtichName1 = Console.ReadLine();
                            Console.WriteLine("New Role (with a number): ");
                            UserRoles switchRole; 
                            Int32 s = Convert.ToInt32(Console.ReadLine());
                            switchRole = (UserRoles)s;
                            UserData.assignUserRole(swtichName1, switchRole);
                            break;
                        case "3":
                            foreach(User user in UserData.TestUsers)
                            {
                                Console.WriteLine(user.name);
                            }break;
                        case "4":
                            StreamReader reader = new StreamReader("test.txt");
                            while(reader != null)
                            {
                                Console.WriteLine(reader.ReadLine());
                            }
                            break;
                        case "5":
                            Console.WriteLine("Write filter: ");
                            String filter = Console.ReadLine();
                            IEnumerable<String> logs = Logger.getCurrentSessionActivities(filter);
                            StringBuilder builder = new StringBuilder();
                            foreach(String log in logs)
                            {
                                builder.Append(log);
                            }
                            Console.WriteLine(builder);
                            break;
                        default: Console.WriteLine("Wrong choice idiot!!!");break;
                    }

                    if (option.Equals("0"))
                    {
                        break;
                    }
                 }

            }
            
            
            Console.ReadLine();
        }
    }
}
