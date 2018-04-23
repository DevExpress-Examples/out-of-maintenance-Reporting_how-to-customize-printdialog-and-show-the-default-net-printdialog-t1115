Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Preview

Namespace GridPrinting
	Partial Public Class MyPrintDialog
		Inherits DevExpress.XtraEditors.Preview.PrintEditorForm
		Public Sub New()
			MyBase.New()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Dim comboBox As ComboBoxEdit = TryCast(GetType(PrintEditorForm).GetField("cbInstalledPrinters", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.GetField Or System.Reflection.BindingFlags.Public Or System.Reflection.BindingFlags.Instance).GetValue(Me), ComboBoxEdit)
			If comboBox IsNot Nothing Then
				For Each item As Object In comboBox.Properties.Items
					If item.ToString() = "Microsoft XPS Document Writer" Then
						comboBox.Properties.Items.Remove(item)
						Return
					End If
				Next item
			End If

		End Sub
	End Class

	Public Class MyRunner
		Inherits PrintDialogRunner
        Public Overrides Function Run(ByVal document As PrintDocument, ByVal lookAndFeel As UserLookAndFeel, ByVal owner As IWin32Window, ByVal flags As PrintDialogAllowFlags) As DialogResult
            Using dialog As New MyPrintDialog()
                dialog.Document = document
                dialog.LookAndFeel.ParentLookAndFeel = lookAndFeel
                Return DevExpress.XtraPrinting.Native.DialogRunner.ShowDialog(dialog, owner)
            End Using
        End Function
	End Class
End Namespace
