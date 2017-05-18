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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student lmacfarl = new Student("lmacfarl", "qwerty64");
            //code for adding unit
            Unit SIT321 = new Unit("SIT321");
            // code for enrolling student in unit
            StudentRecord lmacfarlSR = new StudentRecord(SIT321);
            lmacfarl.RecordList.Add(lmacfarlSR);
            //code for adding attendances
            DB.UserList.Add(lmacfarl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Student username in DB.UserList)
            if (username.Username == txtUser.Text && username.Password == txtPass.Text) {
                StudentForm frm = new StudentForm(username);
                    txtUser.Text = "";
                    txtPass.Text = "";
                frm.Show();
            }
        }
    }
}
