using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBuilder.Management
{
    class MainProcess
    {
        private bool IsRunning = true; // Controls the looping function of the ScreenManager
        public static ScreenManager screenManager = new ScreenManager(); // Creates a new instance of the ScreenManager

        /// <summary>
        /// Directly activates ScreenManager methods through a loop to continuously run the application
        /// </summary>
        public void Run()
        {
            while (IsRunning == true)
            {
                screenManager.Load();
                screenManager.Run();
            }
        }

        /// <summary>
        /// Ends the ScreenManager loop
        /// </summary>
        public void End()
        {
            IsRunning = false;
        }

        /// <summary>
        /// Force closes the application
        /// </summary>
        public void Abort()
        {
            Environment.Exit(0);
        }
    }
}
