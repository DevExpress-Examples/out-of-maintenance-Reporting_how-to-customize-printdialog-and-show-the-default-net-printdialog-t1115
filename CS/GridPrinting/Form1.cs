// Developer Express Code Central Example:
// How to print a GridControl using the PrintTool
// 
// This example shows how you can print a Windows Forms control (e.g.
// DevExpress.XtraGrid.GridControl) using DevExpress.XtraPrinting.PrintTool.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2852

#region #usings
using System;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
// ...
#endregion #usings

namespace GridPrinting {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);
        }

#region #code
private void simpleButton1_Click(object sender, EventArgs e) {
    DevExpress.XtraEditors.Preview.PrintDialogRunner.Instance = new MyRunner();

    PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
    componentLink.Component = gridControl1;
    componentLink.CreateDocument();
    PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
    pt.ShowPreviewDialog();
}
#endregion #code
    }
}
