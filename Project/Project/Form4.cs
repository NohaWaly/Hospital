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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalBDDataSet2.NURSE' table. You can move, or remove it, as needed.
            this.nURSETableAdapter2.Fill(this.hospitalBDDataSet2.NURSE);
            // TODO: This line of code loads data into the 'hospitalBDDataSet2.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter2.Fill(this.hospitalBDDataSet2.EMPLOYEE);
            // TODO: This line of code loads data into the 'hospitalBDDataSet1.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter1.Fill(this.hospitalBDDataSet1.EMPLOYEE);
            // TODO: This line of code loads data into the 'hospitalBDDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'hospitalBDDataSet1.NURSE' table. You can move, or remove it, as needed.
            this.nURSETableAdapter1.Fill(this.hospitalBDDataSet1.NURSE);
            // TODO: This line of code loads data into the 'hospitalBDDataSet.NURSE' table. You can move, or remove it, as needed.
           // this.nURSETableAdapter.Fill(this.hospitalBDDataSet1.NURSE);

        }

      

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "insert into EMPLOYEE values ('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + DateTime.Now.ToString(textBox2.Text) + "','" + textBox7.Text + "','" + textBox6.Text + "');";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "insert into NURSE values ('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + DateTime.Now.ToString(textBox2.Text) + "','" + textBox7.Text + "','" + textBox6.Text + "');";
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
            
            sqlCommand.CommandText = "delete from NURSE  where EMPLOYEE_ID  = '" + textBox1.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "delete from EMPLOYEE  where EMPLOYEE_ID  = '" + textBox1.Text + "';";
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
            sqlCommand.CommandText = "update NURSE set PHONE_NO_ = '" + textBox4.Text + "'where EMPLOYEE_ID = '" + textBox1.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Update is successfully completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.nURSETableAdapter2.Fill(this.hospitalBDDataSet2.NURSE);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "delete from NURSE  where EMPLOYEE_NAME  = '" + textBox3.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "delete from EMPLOYEE  where EMPLOYEE_NAME  = '" + textBox3.Text + "';";
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
            sqlCommand.CommandText = "update NURSE set PHONE_NO_ = '" + textBox4.Text + "'where EMPLOYEE_NAME = '" + textBox3.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Update is successfully completed");

        }
    }
}
