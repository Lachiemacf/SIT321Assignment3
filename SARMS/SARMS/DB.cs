using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    public class DB
    {
        private List<Student> _userList = new List<Student>();
        public List<Student> UserList
        {
            get { return _userList; }
            set { _userList = value; }
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
    }
}
