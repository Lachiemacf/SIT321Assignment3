using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
   public class Unit
    {

        private string _UnitID;
        private List<Student> _StudentList;

        public string UnitID {
            get { return _UnitID; }
            set { _UnitID = value; }
        }
        public List<Student> StudentList
        {
            get { return _StudentList; }
            set { _StudentList = value; }
        }
        public Unit(string unitID) {
            UnitID = unitID;
        }
    }
}
