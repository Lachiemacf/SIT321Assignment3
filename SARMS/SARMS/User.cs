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
        public User(User user)
        {
            _Username = user.Username;
            _Password = user.Password;
        }
        public static User FromCsv(string csvLine)
        {
            //splits all the values in the line into a string array
            string[] values = csvLine.Split(',');
            //sets each value in the array to a certain property of the user, with the first one denoting the type of user
            if (values[0] == "student")
            {
                Student dailyValues = new Student("", "");
                dailyValues._Username = values[1];
                dailyValues._Password = values[2];
                StudentRecord temp = new StudentRecord(DB.ToUnit(values[3]));
                dailyValues.RecordList.Add(temp);
                if (!(values[4].Equals("")))
                {
                    StudentRecord temp2 = new StudentRecord(DB.ToUnit(values[4]));
                    dailyValues.RecordList.Add(temp2);
                }
                return dailyValues;
            }
            else if (values[0] == "lecturer") {
                Lecturer dailyValues = new Lecturer("", "");
                dailyValues._Username = values[1];
                dailyValues._Password = values[2];
                dailyValues.AllocatedUnits.Add(DB.ToUnit(values[3]));
                if (!(values[4].Equals("")))
                {
                    dailyValues.AllocatedUnits.Add(DB.ToUnit(values[4]));
                }
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
