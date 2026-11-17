using System;
using System.Windows.Forms;
using bai6_2.GUI;

namespace bai6_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}
