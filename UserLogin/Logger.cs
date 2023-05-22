using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
     public static class Logger
    {
        private static List<String> activities = new List<String>();

        static public void logActivity(String activity)
        {
            string activityLine = DateTime.Now + ";"
                                  + LoginValidation.currentUser + ";"
                                  + LoginValidation.currentUserRole + ";"
                                  + activity + "n/";
            activities.Add(activityLine);

            if (File.Exists("test.txt"))
            {
                File.AppendAllText("test.txt", activityLine);
            }
        }

        public static IEnumerable<String> getCurrentSessionActivities(string filter) {
            return (from activ in  activities where activ.Contains(filter) select activ).ToList();
        }

    }
}
