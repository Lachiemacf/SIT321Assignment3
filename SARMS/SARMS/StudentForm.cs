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
    public partial class StudentForm : Form
    {
        private Student login;

        public StudentForm(User Loggedin)
        {
            login = (Student)Loggedin;
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            txtlogin.Text = "Logged in as " + login.Username;
            foreach (StudentRecord record in login.RecordList) {
                lstunits.Items.Add(record.Unit.UnitID);
            }
        }
    }
}
