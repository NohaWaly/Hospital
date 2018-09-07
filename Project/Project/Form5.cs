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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void eMPLOYEEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalBDDataSet2);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalBDDataSet2.NURSE' table. You can move, or remove it, as needed.
            this.nURSETableAdapter.Fill(this.hospitalBDDataSet2.NURSE);
            // TODO: This line of code loads data into the 'hospitalBDDataSet2.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.hospitalBDDataSet2.EMPLOYEE);

        }

        private void eMPLOYEEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
