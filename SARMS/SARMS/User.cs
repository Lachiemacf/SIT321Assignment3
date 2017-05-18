using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    public class User
    {
        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public User(string username, string password)
        {
            _Username = username;
            _Password = password;
        }
        public static User FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');

            if (values[0] == "student")
            {
                Student dailyValues = new Student("", "");
                dailyValues._Username = values[1];
                dailyValues._Password = values[2];
                StudentRecord temp = new StudentRecord(DB.ToUnit(values[3]));
                dailyValues.RecordList.Add(temp);
                return dailyValues;
            }
            else if (values[0] == "lecturer") {
                Lecturer dailyValues = new Lecturer("", "");
                dailyValues._Username = values[1];
                dailyValues._Password = values[2];
                return dailyValues;
            }
            else if (values[0] == "admin")
            {
                Admin dailyValues = new Admin("", "");
                dailyValues._Username = values[1];
                dailyValues._Password = values[2];
                return dailyValues;
            }
            return null;
        }
    }
}
