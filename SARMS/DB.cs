using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    static class DB
    {
        private static List<User> _userList = new List<User>();
        public static List<User> UserList
        {
            get { return _userList; }
            set { _userList = value; }
        }
        private static List<Unit> _unitList = new List<Unit>();
        public static List<Unit> UnitList
        {
            get { return _unitList; }

        }

            //Student lmacfarl = new Student("lmacfarl", "qwerty64");
            //code for adding unit
            //Unit SIT321 = new Unit("SIT321");
            // code for enrolling student in unit
            //StudentRecord lmacfarlSR = new StudentRecord(SIT321);
            //lmacfarl.RecordList.Add(lmacfarlSR);
            //code for adding attendances
            //UserList.Add(lmacfarl);

        public static Unit ToUnit(string inputstring) {
            foreach (Unit unit in UnitList) {
                if (inputstring == unit.UnitID) {
                    return unit;
                }
            }
            return null;
        }
        public static User ToUser(string inputstring)
        {
            foreach (User unit in UserList)
            {
                if (inputstring == unit.Username)
                {
                    return unit;
                }
            }
            return null;
        }
    }
}
