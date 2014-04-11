using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using StoryBuilder.Management;

namespace StoryBuilder
{
    static class Program
    {
        static MainProcess mainProcess = new MainProcess();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Thread backThread = new Thread(new ThreadStart(mainProcess.Run));
            backThread.Start();

            while (!backThread.IsAlive)
            {
                Thread.Sleep(1);
            }

        }
    }
}
