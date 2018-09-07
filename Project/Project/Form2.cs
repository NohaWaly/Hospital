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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalBDDataSet.SURGERY' table. You can move, or remove it, as needed.
            this.sURGERYTableAdapter.Fill(this.hospitalBDDataSet.SURGERY);
            // TODO: This line of code loads data into the 'hospitalBDDataSet.PATIENT' table. You can move, or remove it, as needed.
            this.pATIENTTableAdapter.Fill(this.hospitalBDDataSet.PATIENT);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
