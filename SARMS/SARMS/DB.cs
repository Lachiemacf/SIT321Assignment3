using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    public class DB
    {
        private List<User> _userList = new List<User>();
        public List<User> UserList
        {
            get { return _userList; }
            set { _userList = value; }
        }
        private List<Unit> _unitList = new List<Unit>();
        public List<Unit> UnitList
        {
            get { return _unitList; }
            set { _unitList = value; }
        }

        public DB()
        {
            //code for adding user
            Student lmacfarl = new Student("lmacfarl", "qwerty64");
            //code for adding unit
            Unit SIT321 = new Unit("SIT321");
            // code for enrolling student in unit
            StudentRecord lmacfarlSR = new StudentRecord(SIT321);
            lmacfarl.RecordList.Add(lmacfarlSR);
            //code for adding attendances
            UserList.Add(lmacfarl);
        }
        public Unit ToUnit(string inputstring) {
            foreach (Unit unit in UnitList) {
                if (inputstring == unit.UnitID) {
                    return unit;
                }
            }
            return null;
        }
        public User ToUser(string inputstring)
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
