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

        }
    }
}
