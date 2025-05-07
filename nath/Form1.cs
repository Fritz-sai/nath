//Import packages
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace nath
{
    public partial class Form1 : Form
    {
        //Define MYSQL connection using Xampp phpmyadmin database
        private MySqlConnection conn = new MySqlConnection("server=localhost;database=dbnath;username=root;password=;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Retrieve input values from textboxes
            string username = txtusername.Text;
            string password = txtpassword.Text;

            try
            {
                conn.Open(); // Open connection
                //SQL Query
                string query = "SELECT * FROM tblusers WHERE username=@username and password=@password;";
                //Execute query
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Prevent SQL Injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                //Execute command to get value on your query
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //Retrieve user info
                    string name = reader["name"].ToString();
                    string role = reader["role"].ToString();

                    MessageBox.Show($"Welcome {name}! You are logged in as {role}.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (role == "Admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (role == "Student")
                    {
                        StudentForm studentForm = new StudentForm();
                        studentForm.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Do you want to close the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void chShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowpass.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
