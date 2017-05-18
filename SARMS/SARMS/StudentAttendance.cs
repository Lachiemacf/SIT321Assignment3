using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    public class StudentAttendance
    {
        private List<bool> _attendances = new List<bool>();
        public List<bool> attendances
        {
            get { return _attendances; }
            set { _attendances = value; }
        }
    }
}
