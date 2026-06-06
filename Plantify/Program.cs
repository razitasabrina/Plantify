using System;
using System.Windows.Forms;
using plantify.Forms;

namespace plantify
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
    }
}