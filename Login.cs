using MySql.Data.MySqlClient;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace FacialRecognitionServer
{
    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection(DatabaseConnection.connection);

        public Login()
        {
            InitializeComponent();
            //this acts as a connection tester
            /*0string mysqlCon = "server=127.0.0.1; user=root; database=criminaltracing; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                //MessageBox.Show("Connection success");
            }*/
            //catch (Exception ex)
            //{
            //  MessageBox.Show(ex.Message /*"failed to connect to database"*/);
            //Application.Exit();
            //}
            /*finally
            {
                mySqlConnection.Close();
            }*/
        }

        public static string user = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            MySqlDataReader mdr;

            if (string.IsNullOrEmpty(txtLogUsername.Text) || string.IsNullOrEmpty(txtLogPass.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                conn.Open();
                string selectQuery = "SELECT * FROM criminaltracing.users WHERE Username = '" + txtLogUsername.Text + "' AND Password = '" + txtLogPass.Text + "';";
                cmd = new MySqlCommand(selectQuery, conn);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    mdr.Close();

                    string Query = "UPDATE criminaltracing.users set LoginStatus = 'Acitve' WHERE Username='" + this.txtLogUsername.Text + "';";

                    cmd = new MySqlCommand(Query, conn);
                    //MySqlDataReader MyReader2;
                    //MyConn2.Open();
                    mdr = cmd.ExecuteReader();
                    while (mdr.Read())
                    {
                    }
                    conn.Close();

                    user = txtLogUsername.Text;

                    MessageBox.Show("Login Successful!");
                    Home menu = new Home();
                    menu.Show();
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                conn.Close();

            }

        }

        private void btnNoAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register menu = new Register();
            menu.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}