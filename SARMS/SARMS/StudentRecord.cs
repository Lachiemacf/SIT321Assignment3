using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    public class StudentRecord
    {
        private Unit _Unit;
        public Unit Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }
        public StudentRecord(Unit unit) {
            Unit = unit;
        }
        private List<StudentGrade> _GradeList = new List<StudentGrade>();
        public List<StudentGrade> GradeList
        {
            get { return _GradeList; }
            set { _GradeList = value; }
        }
        private StudentAttendance _Attendance = new StudentAttendance();
        public StudentAttendance Attendance
        {
            get { return _Attendance; }
            set { _Attendance = value; }
        }
    }
}
