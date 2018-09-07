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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalBDDataSet.PATIENT' table. You can move, or remove it, as needed.
            this.pATIENTTableAdapter.Fill(this.hospitalBDDataSet.PATIENT);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into PATIENT values ('" + txtboxPID.Text + "','" + DateTime.Now.ToString(txtboxPDOB.Text) + "','" + txtBoxPgender.Text + "','" + txtboxPname.Text + "','" + txtboxPaddress.Text + "','" + txtboxPcontact.Text + "')",sqlConnection);
          
            //sqlCommand.CommandText = "insert into PATIENT values ('" + txtboxPID.Text + "','" + txtboxPDOB.Text+ "','" + txtBoxPgender.Text + "','" + txtboxPname.Text + "','" + txtboxPaddress.Text + "','" + txtboxPcontact.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion is successfully completed");
        }

        private void txtboxPname_TextChanged(object sender, EventArgs e)
        {

        }

        private void patient_Address_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPdata_Click(object sender, EventArgs e)
        {
            this.pATIENTTableAdapter.Fill(this.hospitalBDDataSet.PATIENT);
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "update PATIENT set PATIENT_ADDRESS = '" + txtboxPaddress.Text + "'where PATIENT_ID = '" + txtboxPID.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        
            MessageBox.Show("Update is successfully completed");
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "delete from PATIENT where PATIENT_ID = '" + txtboxPID.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("delete is successfully completed");
        }

        private void btnPSelect_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "delete from PATIENT where PATIENT_NAME = '" + txtboxPname.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("delete is successfully completed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "update PATIENT set PATIENT_ADDRESS = '" + txtboxPaddress.Text + "'where PATIENT_NAME = '" + txtboxPname.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Update is successfully completed");
        }
    }
}
