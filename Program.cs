using MySql.Data.MySqlClient;

namespace FacialRecognitionServer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new ManageFaces());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            /*ApplicationConfiguration.Initialize();
            string mysqlCon = DatabaseConnection.connection;
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                //MessageBox.Show("Connection success");
                Application.Run(new Login());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message");
                //Application.Exit();
            }
            finally
            {
                mySqlConnection.Close();
            }*/
        }
    }
}