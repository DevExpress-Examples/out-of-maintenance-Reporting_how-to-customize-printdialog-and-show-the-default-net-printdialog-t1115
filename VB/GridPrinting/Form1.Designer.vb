' Developer Express Code Central Example:
' How to print a GridControl using the PrintTool
' 
' This example shows how you can print a Windows Forms control (e.g.
' DevExpress.XtraGrid.GridControl) using DevExpress.XtraPrinting.PrintTool.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2852

Namespace GridPrinting
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New GridPrinting.nwindDataSet()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colExtendedPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSalesPerson = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.salesPersonTableAdapter = New GridPrinting.nwindDataSetTableAdapters.SalesPersonTableAdapter()
            Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.salesPersonBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(526, 200)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' salesPersonBindingSource
            ' 
            Me.salesPersonBindingSource.DataMember = "SalesPerson"
            Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colCountry, Me.colFirstName, Me.colLastName, Me.colProductName, Me.colCategoryName, Me.colOrderDate, Me.colUnitPrice, Me.colQuantity, Me.colDiscount, Me.colExtendedPrice, Me.colSalesPerson})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 2
            Me.gridView1.Name = "gridView1"
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { _
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCategoryName, DevExpress.Data.ColumnSortOrder.Ascending), _
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCountry, DevExpress.Data.ColumnSortOrder.Ascending) _
            })
            ' 
            ' colOrderID
            ' 
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.Visible = True
            Me.colOrderID.VisibleIndex = 0
            ' 
            ' colCountry
            ' 
            Me.colCountry.FieldName = "Country"
            Me.colCountry.Name = "colCountry"
            Me.colCountry.Visible = True
            Me.colCountry.VisibleIndex = 1
            ' 
            ' colFirstName
            ' 
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.Visible = True
            Me.colFirstName.VisibleIndex = 2
            ' 
            ' colLastName
            ' 
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.Visible = True
            Me.colLastName.VisibleIndex = 3
            ' 
            ' colProductName
            ' 
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 1
            ' 
            ' colCategoryName
            ' 
            Me.colCategoryName.FieldName = "CategoryName"
            Me.colCategoryName.Name = "colCategoryName"
            Me.colCategoryName.Visible = True
            Me.colCategoryName.VisibleIndex = 4
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 4
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 5
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 6
            ' 
            ' colDiscount
            ' 
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 7
            ' 
            ' colExtendedPrice
            ' 
            Me.colExtendedPrice.FieldName = "Extended Price"
            Me.colExtendedPrice.Name = "colExtendedPrice"
            Me.colExtendedPrice.OptionsColumn.ReadOnly = True
            Me.colExtendedPrice.Visible = True
            Me.colExtendedPrice.VisibleIndex = 8
            ' 
            ' colSalesPerson
            ' 
            Me.colSalesPerson.FieldName = "Sales Person"
            Me.colSalesPerson.Name = "colSalesPerson"
            Me.colSalesPerson.OptionsColumn.ReadOnly = True
            Me.colSalesPerson.Visible = True
            Me.colSalesPerson.VisibleIndex = 9
            ' 
            ' salesPersonTableAdapter
            ' 
            Me.salesPersonTableAdapter.ClearBeforeFill = True
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(147, 220)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(236, 63)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Preview the Grid"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(526, 318)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private nwindDataSet As nwindDataSet
        Private salesPersonBindingSource As System.Windows.Forms.BindingSource
        Private salesPersonTableAdapter As nwindDataSetTableAdapters.SalesPersonTableAdapter
        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
        Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
        Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
        Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Private colExtendedPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colSalesPerson As DevExpress.XtraGrid.Columns.GridColumn
        Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

