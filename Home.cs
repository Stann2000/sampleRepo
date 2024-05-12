using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacialRecognitionServer
{
    public partial class Home : Form
    {
        MySqlConnection conn = new MySqlConnection(DatabaseConnection.connection);

        public Home()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            conn.Open();
            string currentuser = Login.user;
            MySqlCommand cmd;
            string Query = "UPDATE criminaltracing.users set LoginStatus = 'Not Acitve' WHERE Username='" + currentuser + "';";

            cmd = new MySqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            Login menu = new Login();
            menu.Show();
            this.Close();
        }
    }
}
