using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sURGERYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sURGERYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalBDDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalBDDataSet2.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.hospitalBDDataSet2.DataTable1);

            // TODO: This line of code loads data into the 'hospitalBDDataSet2.NURSE' table. You can move, or remove it, as needed.
            this.nURSETableAdapter.Fill(this.hospitalBDDataSet2.NURSE);
            // TODO: This line of code loads data into the 'hospitalBDDataSet2.SURGERY' table. You can move, or remove it, as needed.
            this.sURGERYTableAdapter1.Fill(this.hospitalBDDataSet2.SURGERY);
            // TODO: This line of code loads data into the 'hospitalBDDataSet.SURGERY' table. You can move, or remove it, as needed.
            this.sURGERYTableAdapter.Fill(this.hospitalBDDataSet.SURGERY);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "select SURGERY.SURGERY_NO_ ,DOCTOR.EMPLOYEE_NAME,NURSE.EMPLOYEE_NAME,SURGERY.SURGERY_DATE from SURGERY, DOCTOR, NURSE, HELP_IN, CARRY_OUT where DOCTOR.EMPLOYEE_ID = CARRY_OUT.EMPLOYEE_ID and NURSE.EMPLOYEE_ID = HELP_IN.EMPLOYEE_ID and SURGERY.SURGERY_NO_ = HELP_IN.SURGERY_NO_ and SURGERY.SURGERY_NO_ = CARRY_OUT.SURGERY_NO_;";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            
            MessageBox.Show("Selection is successfully completed");
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sURGERYTableAdapter1.FillBy(this.hospitalBDDataSet2.SURGERY);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
