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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dOCTORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCTORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalBDDataSet2);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalBDDataSet2.DOCTOR' table. You can move, or remove it, as needed.
            this.dOCTORTableAdapter.Fill(this.hospitalBDDataSet2.DOCTOR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
