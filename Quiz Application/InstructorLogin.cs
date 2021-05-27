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

namespace Quiz_Application
{
    public partial class InstructorLogin : Form
    {
        public InstructorLogin()
        {
            InitializeComponent();
        }

        public string dbConString = "Data Source=WAHAJORGANIZATI\\SQLEXPRESS;Initial Catalog=QuizApplication;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection dbConnection = new SqlConnection(dbConString);
                //dbConnection.Open();
                //string query = "insert into instructor(id,password)values('"+ textBox1.Text.ToString()+ "','"+textBox2.Text.ToString()+"')";
                //SqlCommand cmd = new SqlCommand(query, dbConnection);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Data Saved Successfully");

                SqlConnection dbConnection = new SqlConnection(dbConString);
                dbConnection.Open();
                string query = "Select Password from instructor where id = @id";
                SqlCommand cmd = new SqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@id", int.Parse(ID.Text));
                SqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    Password.Text = "asdas";
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
