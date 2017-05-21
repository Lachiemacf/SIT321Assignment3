using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    class Staff : User
    {
        public Staff(string username, string password) : base(username, password)
        {
        }
        public void addGrade(Student student, Unit unit, Double grade, string asignID, string feedback) {

            foreach (StudentRecord record in student.RecordList) {
                if (record.Unit.UnitID == unit.UnitID) {
                    StudentGrade stugrade = new StudentGrade(grade, asignID, feedback);
                    record.GradeList.Add(stugrade);
                }
            }

        }
    }
}
