using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    class Student : User
    {
        private List<StudentRecord> _RecordList;
        public List<StudentRecord> RecordList
        {
            get { return _RecordList; }
            set { _RecordList = value; }
        }
    }
}
