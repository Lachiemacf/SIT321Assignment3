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
        private List<Student> _StudentList = new List<Student>();
             
        public string UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }
        public List<Student> StudentList
        {
            get { return _StudentList; }
            set { _StudentList = value; }
        }
        public Unit(string unitID)
        {
            UnitID = unitID;
        }
        public static Unit FromCsv(string csvLine)
        {
            //creates a new unit object from each value in the csv line
            string[] values = csvLine.Split(',');

            Unit dailyValues = new Unit("");
            dailyValues._UnitID = values[0];
            return dailyValues;

        }
    }
}
