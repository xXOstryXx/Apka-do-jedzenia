using System;
using System.Windows.Forms;

namespace Apka_do_jedzenia
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}