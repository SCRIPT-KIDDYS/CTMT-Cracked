﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTMT_Cracked
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static bool SplashScreenClosed { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreenClosed = false;
            Application.Run(new SplashScreen());
            if (SplashScreenClosed)
            {
                Application.Run(new MainWindow());
            }
        }
    }
}