using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Preview;
using DevExpress.XtraPrinting.Preview;

namespace GridPrinting {
    public partial class MyPrintDialog : PrintEditorForm {
        public MyPrintDialog()
            : base() {
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            ImageComboBoxEdit comboBox = typeof(PrintEditorForm).GetField("icbInstalledPrinters", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance).GetValue(this) as ImageComboBoxEdit;
            if(comboBox != null)
                foreach(object item in comboBox.Properties.Items)
                    if(item.ToString() == "Microsoft XPS Document Writer") {
                        comboBox.Properties.Items.Remove(item);
                        return;
                    }

        }
    }

    public class MyRunner : PrintDialogRunner {
        //public override DialogResult Run(PrintDocument document, UserLookAndFeel lookAndFeel, IWin32Window owner) {
        //   
        //}
        public override DialogResult Run(PrintDocument document, UserLookAndFeel lookAndFeel, IWin32Window owner, PrintDialogAllowFlags flags)
        {
           using(MyPrintDialog dialog = new MyPrintDialog()) {
               dialog.Document = document;
               dialog.LookAndFeel.ParentLookAndFeel = lookAndFeel;
               return DevExpress.XtraPrinting.Native.DialogRunner.ShowDialog(dialog, owner);
           }
        }
    }
}
