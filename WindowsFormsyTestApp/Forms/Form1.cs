using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsyTestApp.Forms;
using WindowsFormsyTestApp.Models;

namespace WindowsFormsyTestApp
{
    public partial class Form1 : Form
    {
        BindingSource bindingSource = new BindingSource();
        List<transportType> transportTypes = new List<transportType>();
        public Form1()
        {
            InitializeComponent();
            using (var db = new transportEntities())
            {
                transportTypes = db.transportType.ToList();
            }
            
            bindingSource.DataSource = transportTypes;
            transportTypeDataGridView.DataSource = bindingSource;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new InfoTransportForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new transportEntities())
                {
                    db.transportType.Add(form.Transport);
                    db.SaveChanges();
                    transportTypes = db.transportType.ToList();
                    bindingSource.DataSource = transportTypes;
                }
            }
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new transportEntities())
            {
                transportTypes = db.transportType.OrderBy(xyu => xyu.count_of).ToList();
                bindingSource.DataSource = transportTypes;
            }
        }

        private void desToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transportTypes.Reverse();
            bindingSource.DataSource = transportTypes;


            bindingSource.ResetBindings(false);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            using (var db = new transportEntities())
            {
                if (int.TryParse(textBoxBefore.Text, out var before) && int.TryParse(textBoxAfter.Text, out var after))
                {
                    transportTypes = db.transportType.Where(xyu => xyu.cost_of >= before && xyu.cost_of <= after).ToList();
                }
                else if (int.TryParse(textBoxBefore.Text, out before))
                {
                    transportTypes = db.transportType.Where(xyu => xyu.cost_of >= before).ToList();
                }
                else if (int.TryParse(textBoxAfter.Text,out after))
                {
                    transportTypes = db.transportType.Where(xyu => xyu.cost_of <= after).ToList();
                }

                bindingSource.DataSource = transportTypes;
            } 
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?", "?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                transportType transportDVG = (transportType)transportTypeDataGridView.Rows[transportTypeDataGridView.SelectedRows[0].Index].DataBoundItem;

                using (var db = new transportEntities())
                {
                    foreach (DataGridViewRow row in transportTypeDataGridView.SelectedRows)
                    {
                        var tr = (transportType)transportTypeDataGridView
                        .Rows[row.Index].DataBoundItem;


                        db.transportType.Remove(db.transportType.FirstOrDefault(x => x.id_type == tr.id_type));
                    }

                    db.SaveChanges();

                    transportTypes = db.transportType.ToList();
                    bindingSource.DataSource = transportTypes;


                }
            }
        }

            

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tr = (transportType)transportTypeDataGridView
                   .SelectedRows[0].DataBoundItem;

            var form = new InfoTransportForm(tr);

            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new transportEntities())
                {
                    var dbTransport = db.transportType.FirstOrDefault(x => x.id_type == tr.id_type);
                    if (dbTransport != null)
                    {
                        dbTransport.name_of = form.Transport.name_of;
                        dbTransport.count_of = form.Transport.count_of;
                        dbTransport.cost_of = form.Transport.cost_of;
                        dbTransport.avgspeed_of = form.Transport.avgspeed_of;
                    }
                    db.SaveChanges();
                    transportTypes = db.transportType.ToList();
                    bindingSource.DataSource = transportTypes;
                }
            }

        }

        private void textBoxBefore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
