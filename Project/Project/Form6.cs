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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalBDDataSet2.DOCTOR' table. You can move, or remove it, as needed.
            this.dOCTORTableAdapter.Fill(this.hospitalBDDataSet2.DOCTOR);
            //this.eMPLOYEETableAdapter.Fill(this.hospitalBDDataSet2.EMPLOYEE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "insert into EMPLOYEE values ('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + DateTime.Now.ToString(textBox2.Text) + "','" + textBox7.Text + "','" + textBox6.Text + "');";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "insert into DOCTOR values ('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + DateTime.Now.ToString(textBox2.Text) + "','" + textBox7.Text + "','" + textBox6.Text + "','" +textBox8.Text+ "');";

            // SqlCommand sqlCommand = new SqlCommand("insert into DOCTOR values ('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + DateTime.Now.ToString(textBox2.Text) + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox8.Text+"')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion is successfully completed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "delete from DOCTOR where EMPLOYEE_ID ='" + textBox1.Text + "';";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "delete from EMPLOYEE where EMPLOYEE_ID ='" + textBox1.Text + "';";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("delete is successfully completed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "update EMPLOYEE set PHONE_NO_ = '" + textBox4.Text + "'where EMPLOYEE_ID = '" + textBox1.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "update DOCTOR set PHONE_NO_ = '" + textBox4.Text + "'where EMPLOYEE_ID = '" + textBox1.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Update is successfully completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dOCTORTableAdapter.Fill(this.hospitalBDDataSet2.DOCTOR);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "delete from DOCTOR where EMPLOYEE_NAME ='" + textBox3.Text + "';";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "delete from EMPLOYEE where EMPLOYEE_NAME ='" + textBox3.Text + "';";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("delete is successfully completed");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "update EMPLOYEE set PHONE_NO_ = '" + textBox4.Text + "'where EMPLOYEE_NAME = '" + textBox3.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "update DOCTOR set PHONE_NO_ = '" + textBox4.Text + "'where EMPLOYEE_NAME = '" + textBox3.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Update is successfully completed");
        }
    }
}
