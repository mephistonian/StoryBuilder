using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryBuilder.Screens;

namespace StoryBuilder.Management
{
    class ScreenManager
    {
        private bool IsRunning = true;
        private bool IsLoading = true;
        private bool newActiveScreen;
        private ParentScreen activeScreen;

        /// <summary>
        /// Used to change between different screens
        /// </summary>
        /// <param name="newScreen">Determines the next active screen</param>
        public void ChangeScreen(ParentScreen newScreen)
        {
            newActiveScreen = true;
            IsLoading = true;

            this.activeScreen = newScreen;

            Load();
            Run();
        }

        public void Load()
        {
            if (IsLoading == true)
            {
                if (newActiveScreen == false)
                {
                    activeScreen = new DemoScreen(); // This is the first screen to be loaded upon running the application
                }

                activeScreen.Load();
            }
            IsLoading = false;
        }

        public void Run()
        {
            activeScreen.Run();
        }
    }
}
