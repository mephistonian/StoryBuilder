using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoryBuilder.Management;

namespace StoryBuilder.Screens
{
    class DemoScreen : ParentScreen
    {

        ScreenManager screenManager = MainProcess.screenManager;

        public override void Load()
        {
            base.Load();
            Form1._Form1.SetText = "This is a test.";
        }

        public override void Run()
        {
            base.Run();
        }
    }
}
