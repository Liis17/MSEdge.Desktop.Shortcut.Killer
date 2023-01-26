using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MSEdge.Desktop.Shortcut.Killer
{
    public class Checker
    {
        static DispatcherTimer timemachine = new DispatcherTimer();

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Microsoft Edge.lnk";
        static string pathCanary = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Microsoft Edge Canary.lnk";
        public static void Start()
        {
            Timer();
        }
        public static void Timer()
        {
            timemachine.Interval = TimeSpan.FromSeconds(10);
            timemachine.Tick += Check;
            timemachine.Start();
        }

        private static void Check(object? sender, EventArgs e)
        {
            if (File.Exists(path) == true)
            {
                Kill.KillShortcut(path);
            }
            if (File.Exists(pathCanary) == true)
            {
                Kill.KillShortcutCanary(pathCanary);
            }

            //для остановки
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\stop.txt") == true)
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\stop.txt");
                Application.Current.Shutdown();
            }
        }
    }
}
