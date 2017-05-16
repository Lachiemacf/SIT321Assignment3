using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    class StudentRecord
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
    }
}
