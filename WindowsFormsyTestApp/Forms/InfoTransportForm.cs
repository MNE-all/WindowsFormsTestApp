using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsyTestApp.Models;

namespace WindowsFormsyTestApp.Forms
{
    public partial class InfoTransportForm : Form
    {
        public transportType Transport { get; set; }
        public InfoTransportForm()
        {
            InitializeComponent();
        }
        public InfoTransportForm(transportType transport)
        {
            InitializeComponent();

            Transport = transport;

            nameTextBox.Text = transport.name_of;
            AVGNumericUpDown.Value = transport.avgspeed_of;
            AmoutOfCarNumericUpDown.Value = transport.count_of;
            totalPriceNumericUpDown.Value = transport.cost_of;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Transport = new transportType
            {
                name_of = nameTextBox.Text,
                avgspeed_of = (int)AVGNumericUpDown.Value,
                count_of = (int)AmoutOfCarNumericUpDown.Value,
                cost_of = (int)totalPriceNumericUpDown.Value,
            };
        }
    }
}
