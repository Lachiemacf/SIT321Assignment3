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
    public partial class LecturerForm : Form
    {
        private Lecturer login;

        public LecturerForm(User Loggedin)
        {
            login = (Lecturer)Loggedin;
            InitializeComponent();
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
