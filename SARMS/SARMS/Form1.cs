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
            DB.LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User username in DB.UserList)
            if (username.Username == txtUser.Text && username.Password == txtPass.Text) {
                    if (username is Student)
                    {
                        StudentForm frm = new StudentForm(username);
                        frm.Show();
                    }
                    if (username is Lecturer)
                    {
                        LecturerForm frm = new LecturerForm(username);
                        frm.Show();
                    }
                    if (username is Admin)
                    {
                        AdminForm frm = new AdminForm(username);
                        frm.Show();
                    }

            }
        }
    }
}
