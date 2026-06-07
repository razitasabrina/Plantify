using plantify.Forms;
using plantify.Models;
using System;
using System.Windows.Forms;

namespace plantify
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(
    new FormKatalog(
        new Customer()
        {
            Nama = "Razita"
        }
    )
);
        }
    }
}