using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace NicerNames
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.GetLength(0) > 0)
            {
                foreach (string a in args)
                {
                    Program.Rename(a);
                }
                return;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmNicerNames());
            }
        }

        public static bool Rename(string s)
        {
            try
            {
                FileInfo fi = new FileInfo(s);
                string newName = HttpUtility.UrlDecode(fi.Name);
                File.Move(fi.FullName, fi.DirectoryName + Path.DirectorySeparatorChar + newName);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
