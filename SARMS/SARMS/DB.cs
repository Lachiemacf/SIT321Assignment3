using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    public static class DB
    {
        private static List<User> _userList = new List<User>();
        public static List<User> UserList
        {
            get { return _userList; }
            set { _userList = value; }
        }
        private static List<Unit> _unitList = new List<Unit>();
        public static List<Unit> UnitList
        {
            get { return _unitList; }
            set { _unitList = value; }
        }

        public static Unit ToUnit(string inputstring) {
            //a units id is inputted and the unit is returned
            foreach (Unit unit in UnitList) {
                if (inputstring == unit.UnitID) {
                    return unit;
                }
            }
            return null;
        }
        public static User ToUser(string inputstring)
        {
            foreach (User unit in UserList)
            {
                //a users id is inputted and the user is returned
                if (inputstring == unit.Username)
                {
                    return unit;
                }
            }
            return null;
        }
        public static Student ToStudent(string inputstring)
        {
            //a students id is inputted and the student is returned
            foreach (Student unit in UserList)
            {
                if (inputstring == unit.Username && unit is Student)
                {
                    return unit;
                }
            }
            return null;
        }
            public static void LoadData()
        {
            //reads both the .csv files to insert the user and unit lists
            _unitList = File.ReadAllLines("unit.csv").Select(v => Unit.FromCsv(v)).ToList();
            _userList = File.ReadAllLines("users.csv") .Select(v => User.FromCsv(v)).ToList();
            addStudents();
        }
        private static void addStudents()
        {
            //with both the units and students added, it competes the process by adding every student with the records of being in a unit, to that unit's studentlist
            foreach (User user in _userList) {
                if (user is Student) {
                    Student Temp = new Student(user as Student);
                    foreach (StudentRecord record in Temp.RecordList)
                    {
                        record.Unit.StudentList.Add(Temp);
                    }
                }
                }
            }
        }
        }
