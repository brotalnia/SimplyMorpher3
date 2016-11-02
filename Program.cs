// Simply Morpher 3
// Original by NEM E5I5
// Improved and updated for Windows 10 by brotalnia
// Visit www.youtube.com/brotalnia for more stuff by me.

using System;
using System.Windows.Forms;

namespace SimplyMorpher
{
    internal static class Program
    {
        public static Random rnd = new Random();
        public static int Rand(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }
        public static bool logtofile = false;
        [STAThread]
        private static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Contains("log"))
                {
                    logtofile = true;
                    break;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((Form) new Form1());
        }
    }
}
