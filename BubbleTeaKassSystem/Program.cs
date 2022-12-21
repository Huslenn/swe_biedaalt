using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTeaKassSystem
{
    static class Global
    {
        public static SqlConnection conn { get; set; }
        public static String user { get; set; }
        public static int userId { get; set; }
        public static bool isManager { get; set; }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JBKVKBH;Initial Catalog=employee;Integrated Security=True");
            Global.conn = conn;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        
    }
}
