using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEdge.Desktop.Shortcut.Killer
{
    public class Kill
    {
        // да это требовало создавать отдельный класс, еще вопросы?
        public static void KillShortcutCanary(string path)
        {
            File.Delete(path);
        }
        public static void KillShortcut(string path)
        {
            File.Delete(path);
        }
    }
}
