// Developer Express Code Central Example:
// How to print a GridControl using the PrintTool
// 
// This example shows how you can print a Windows Forms control (e.g.
// DevExpress.XtraGrid.GridControl) using DevExpress.XtraPrinting.PrintTool.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2852

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GridPrinting {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
