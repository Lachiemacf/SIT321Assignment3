using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    public class Student : User
    {
        private List<StudentRecord> _RecordList = new List<StudentRecord>();
        public List<StudentRecord> RecordList
        {
            get { return _RecordList; }
            set { _RecordList = value; }
        }

        public Student(string username, string password) : base (username,password)
        {
        }
        public Student(Student user) : base(user)
        {
            _RecordList = user._RecordList;
        }
    }
}
