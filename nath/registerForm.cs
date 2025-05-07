using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Import necessary namespaces for MySQL and Windows Forms functionality
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace nath
{
    public partial class registerForm : Form
    {
        // Define MySQL connection using XAMPP's phpMyAdmin database
        private MySqlConnection conn = new MySqlConnection("server=localhost;database=dbnath;username=root;password=;");
        public registerForm()
        {
            InitializeComponent();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
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
            //Validate if all input are filled
            if (string.IsNullOrWhiteSpace(txtusername.Text) ||
                string.IsNullOrWhiteSpace(txtlastname.Text) ||
                string.IsNullOrWhiteSpace(txtfirstname.Text) ||
                string.IsNullOrWhiteSpace(txtmiddlename.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text) ||
                comboBox1.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1
                )
            {
                MessageBox.Show("All fields must be filled out", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM tblstudentinfo WHERE studentno = @StudentNo";
                MySqlCommand checkcmd = new MySqlCommand(checkQuery, conn);
                checkcmd.Parameters.AddWithValue("@StudentNo", txtusername.Text);
                int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Student No. already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtusername.Clear();
                    return;
                }
                //Insert student information into the database
                string registerquery = "INSERT INTO tblstudentinfo (studentno, lastname, firstname, middlename, birthdate, course, section)" +
                    "VALUES (@StudentNo, @Lastname, @Firstname, @Middlename, @Birthdate, @Course, @Section)";
                MySqlCommand cmd = new MySqlCommand(registerquery, conn);
                cmd.Parameters.AddWithValue("@StudentNo", txtusername.Text);
                cmd.Parameters.AddWithValue("@Lastname", txtlastname.Text);
                cmd.Parameters.AddWithValue("@Firstname", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@Middlename", txtmiddlename.Text);
                cmd.Parameters.AddWithValue("@Birthdate", bday.Value);
                cmd.Parameters.AddWithValue("@Course", comboBox2.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem.ToString());
                cmd.ExecuteNonQuery(); // Execute insert query

                string name = txtfirstname.Text + " " + txtlastname.Text;

                //Insert user credentials in the tblusers table
                string registeruser = "INSERT INTO tblusers (name, username, password, role) " +
                    "VALUES (@name, @username, @password, 'Student')";
                MySqlCommand cmd2 = new MySqlCommand(registeruser, conn);
                cmd2.Parameters.AddWithValue("@name", name);
                cmd2.Parameters.AddWithValue("@username", txtusername.Text);
                cmd2.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd2.ExecuteNonQuery(); // Execute insert query

                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clear All inputs
                txtusername.Clear();
                txtlastname.Clear();
                txtfirstname.Clear();
                txtmiddlename.Clear();
                txtpassword.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.Items.Clear();


            }
            catch (Exception ex)
            {
                // Display error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close(); // Ensure database connection is closed after operation
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (comboBox2.SelectedIndex == 0)
            {
                comboBox1.Items.Add("ACT 1A");
                comboBox1.Items.Add("ACT 1B");
                comboBox1.Items.Add("ACT 1E");
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                comboBox1.Items.Add("HM 1A");
                comboBox1.Items.Add("HM 1B");
                comboBox1.Items.Add("HM 1E");
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                comboBox1.Items.Add("BSOA 1A");
                comboBox1.Items.Add("BSOA 1B");
                comboBox1.Items.Add("BSOA 1E");
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

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // prevent user from typing in the combobox
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // prevent user from typing in the combobox
        }
    }
}
