using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickWorks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new OrdersForm());
                //var db = new BrickWorksModel();


                //Console.WriteLine("OrdersView from Code:");
                //var orders = db.Orders.Select(o => new OV
                //{
                //    OrderId = o.Id,
                //    OrderedDate = o.OrderedDate,
                //    Client = o.Client.Name
                //}).ToList();

                //foreach(var o in orders)
                //{
                //    Console.WriteLine("{0} {1} {2} {3}", o.OrderId, o.OrderedDate, o.Client, o.Amount);
                //}
                //Console.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
