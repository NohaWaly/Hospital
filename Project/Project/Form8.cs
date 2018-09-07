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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalBDDataSet2.APPOINTMENT' table. You can move, or remove it, as needed.
            this.aPPOINTMENTTableAdapter.Fill(this.hospitalBDDataSet2.APPOINTMENT);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into APPOINTMENT values ('" + textBox1.Text + "','" + textBox2.Text+ "','" + textBox3.Text + "','" + DateTime.Now.ToString(textBox4.Text) + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion is successfully completed");
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "update APPOINTMENT set APPOINTMENT_DATE = '" + DateTime.Now.ToString(textBox4.Text) + "'where APPOINTMENT_NO_ = '" +textBox1.Text+ "';";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Update is successfully completed");
        }

        private void btnADelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=HospitalBD;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "delete from APPOINTMENT where APPOINTMENT_NO_ = '" + textBox1.Text + "';";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("delete is successfully completed");
        }

        private void btnAdata_Click(object sender, EventArgs e)
        {
            this.aPPOINTMENTTableAdapter.Fill(this.hospitalBDDataSet2.APPOINTMENT);
        }

        private void btnASelect_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
    }
}
