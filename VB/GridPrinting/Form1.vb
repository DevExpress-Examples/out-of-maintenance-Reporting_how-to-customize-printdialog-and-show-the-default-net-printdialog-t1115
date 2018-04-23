' Developer Express Code Central Example:
' How to print a GridControl using the PrintTool
' 
' This example shows how you can print a Windows Forms control (e.g.
' DevExpress.XtraGrid.GridControl) using DevExpress.XtraPrinting.PrintTool.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2852

#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
' ...
#End Region ' #usings

Namespace GridPrinting
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)
        End Sub

        #Region "#code"
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            PrintDialogRunner.Instance = New MyRunner()

            Dim componentLink As New PrintableComponentLink(New PrintingSystem())
            componentLink.Component = gridControl1
            componentLink.CreateDocument()
            Dim pt As New PrintTool(componentLink.PrintingSystemBase)
            pt.ShowPreviewDialog()
        End Sub
        #End Region ' #code
    End Class
End Namespace
