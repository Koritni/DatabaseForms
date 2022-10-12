using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Mutex mutex = new Mutex(false, "prog");
            if(!mutex.WaitOne(0, false))
            {
                MessageBox.Show("Программа уже запущена");
                return;
            }
            Application.Run(new Form1());
        }
    }
}
