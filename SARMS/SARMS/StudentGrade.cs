using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    public class StudentGrade
    {
        private double _Grade;

        public double Grade {
            get { return _Grade; }
            set { _Grade = value; }
        }

        private string _AssignmentID;

        public string AssignmentID
        {
            get { return _AssignmentID; }
            set { _AssignmentID = value; }
        }
        private string _Feedback;

        public string Feedback
        {
            get { return _Feedback; }
            set { _Feedback = value; }
        }
    }
}
