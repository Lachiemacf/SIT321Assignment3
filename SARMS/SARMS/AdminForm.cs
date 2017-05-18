using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARMS
{
    public partial class AdminForm : Form
    {
        private Admin login;

        public AdminForm(User Loggedin)
        {
            login = (Admin)Loggedin;
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            foreach (User User in DB.UserList)
            {
                if (User is Student)
                {
                    lststudents.Items.Add(User.Username);
                }
            }
            foreach (Unit unit in DB.UnitList)
            {
                foreach (StudentRecord record in DB.ToStudent(lststudents.SelectedItem.ToString()).RecordList)
                    if (record.Unit != unit)
                    {
                        lstunits.Items.Add(unit.UnitID);
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lststudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (User User in DB.UserList)
            {
                if (User is Student)
                {
                    lststudents.Items.Add(User.Username);
                }
            }
            foreach (Unit unit in DB.UnitList)
            {
                foreach (StudentRecord record in DB.ToStudent(lststudents.SelectedItem.ToString()).RecordList)
                    if (record.Unit != unit)
                    {
                        lstunits.Items.Add(unit.UnitID);
                    }
            }
        }
    }
}
