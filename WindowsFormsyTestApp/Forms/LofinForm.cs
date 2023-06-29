using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsyTestApp.Models;

namespace WindowsFormsyTestApp.Forms
{
    public partial class LofinForm : Form
    {
        public LofinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new transportEntities())
            {
                var user = db.register.FirstOrDefault(x => x.login_user == textBoxLogin.Text &&
                x.password_user == textBoxPassword.Text);
                if (user != null)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Увы");
                }
            }
        }
    }
}
