using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             //TicketMS  t= new t2("")

            BusA s = new Ena("ABC", 40, 1);
            Ena r = new Ena();
           // TicketMS t = new SignUp();
            //t.name = txtName;
         
            //s.name = txtName;
            //s.Bpayment();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
