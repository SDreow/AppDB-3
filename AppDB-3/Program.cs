using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_DB_3
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

            // Vytvoření instance třídy TestLINQ a spuštění metody Test
            var testLINQ = new TestLINQ();
            //testLINQ.Test();
            //testLINQ.Test2();
            //testLINQ.InnerJoinProductsAndCategories();
            //testLINQ.LeftJoinProductsAndCategories();
            //testLINQ.Groupování();
            testLINQ.VybratVice();

            // Spuštění hlavního formuláře aplikace
            //Application.Run(new HomeForm());
            Application.Run(new TestLinqForm());
        }
    }
}