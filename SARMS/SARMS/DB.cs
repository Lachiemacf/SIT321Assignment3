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
                if (inputstring == unit.Username)
                {
                    return unit;
                }
            }
            return null;
        }
        public static Student ToStudent(string inputstring)
        {
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
            _userList = File.ReadAllLines("users.csv") .Select(v => User.FromCsv(v)).ToList();
            _unitList = File.ReadAllLines("unit.csv").Select(v => Unit.FromCsv(v)).ToList();
        }

        }

    }
