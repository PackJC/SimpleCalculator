//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Simple Calculator
//	File Name:		Driver.cs
//	Description:    Driver
//	Author:			Johnny Pack, packjc@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday, May 11, 2020
//	Copyright:		Johnny Pack, 2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    /// <summary>
    /// Driver class
    /// </summary>
    static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
