using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FacialRecognitionServer
{
    public partial class Register : Form
    {
        MySqlConnection mysqlCon = new MySqlConnection(DatabaseConnection.connection);
        //MySqlCommand cmd;
        //MySqlDataReader mdr;

        public Register()
        {
            InitializeComponent();

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            Login menu = new Login();

            if (!this.txtRegEmail.Text.Contains('@') || !this.txtRegEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtRegPass.Text != txtRegCPass.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            else if (string.IsNullOrEmpty(txtRegId.Text) || string.IsNullOrEmpty(txtRegFName.Text) || string.IsNullOrEmpty(txtRegEmail.Text) || string.IsNullOrEmpty(txtRegPosition.Text) || string.IsNullOrEmpty(txtRegUsername.Text) || string.IsNullOrEmpty(txtRegPass.Text) || string.IsNullOrEmpty(txtRegCPass.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                mysqlCon.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM criminaltracing.users WHERE Username = '" + txtRegUsername.Text + "'", mysqlCon),
                cmd2 = new MySqlCommand("SELECT * FROM criminaltracing.users WHERE Email = '" + txtRegEmail.Text + "'", mysqlCon);


                cmd1.Parameters.AddWithValue("@UserName", txtRegUsername.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", txtRegEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO criminaltracing.users(`WorkID`,`Name`,`Email`,`Position`,`Username`, `Password`) VALUES ('" + txtRegId.Text + "', '" + txtRegFName.Text + "', '" + txtRegEmail.Text + "', '" + txtRegPosition.Text + "', '" + txtRegUsername.Text + "', '" + txtRegPass.Text + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, mysqlCon);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");
                    txtRegId.Text = "";
                    txtRegFName.Text = "";
                    txtRegEmail.Text = "";
                    txtRegPosition.Text = "";
                    txtRegUsername.Text = "";
                    txtRegPass.Text = "";
                    txtRegCPass.Text = "";

                }

                mysqlCon.Close();
            }

        }

        private void btnBackReg_Click(object sender, EventArgs e)
        {
            Login menu = new Login();
            menu.Show();
            this.Hide();
        }
    }
}
