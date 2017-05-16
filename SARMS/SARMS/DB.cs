using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    class DB
    {
        private List<Student> _userList = new List<Student>();
        public List<Student> userList
        {
            get { return _userList; }
            set { _userList = value; }
        }

        public DB()
        {
            Student lmacfarl = new Student("lmacfarl", "qwerty64");
            Unit SIT321 = new Unit("SIT321");
            StudentRecord lmacfarlSR = new StudentRecord(SIT321);
            lmacfarl.RecordList.Add(lmacfarlSR);
            userList.Add(lmacfarl);
        }
    }
}
