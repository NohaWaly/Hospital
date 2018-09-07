using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void aPPOINTMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPPOINTMENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalBDDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalBDDataSet2.APPOINTMENT' table. You can move, or remove it, as needed.
            this.aPPOINTMENTTableAdapter1.Fill(this.hospitalBDDataSet2.APPOINTMENT);
            // TODO: This line of code loads data into the 'hospitalBDDataSet.APPOINTMENT' table. You can move, or remove it, as needed.
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
