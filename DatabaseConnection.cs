using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FacialRecognitionServer
{
    internal class DatabaseConnection
    {
       public static string connection = "server=192.168.8.111; user=root; database=criminaltracing; password=";
    }
}
