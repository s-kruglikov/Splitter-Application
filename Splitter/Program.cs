﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Splitter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			var mainForm = new MainForm();

			//inject dependencies
			var mainPresenter = new MainPresenter(mainForm);

            Application.Run(mainForm);
        }
    }
}
