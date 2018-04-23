' Developer Express Code Central Example:
' How to print a GridControl using the PrintTool
' 
' This example shows how you can print a Windows Forms control (e.g.
' DevExpress.XtraGrid.GridControl) using DevExpress.XtraPrinting.PrintTool.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2852

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace GridPrinting
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace
