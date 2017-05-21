using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    class Lecturer : Staff
    {
        public Lecturer(string username, string password) : base(username, password)
        {
        }
        private List<Unit> _AllocatedUnits = new List<Unit>();
        public List<Unit> AllocatedUnits
        {
            get { return _AllocatedUnits; }
            set { _AllocatedUnits = value; }
        }
    }
}
