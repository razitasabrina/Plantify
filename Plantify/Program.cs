using System;
using System.Windows.Forms;
using Plantify.Forms;

namespace Plantify
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