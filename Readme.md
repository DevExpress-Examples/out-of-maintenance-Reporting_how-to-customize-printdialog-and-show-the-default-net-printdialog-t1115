<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/GridPrinting/Form1.cs) (VB: [Form1.vb](./VB/GridPrinting/Form1.vb))
* **[Form2.cs](./CS/GridPrinting/Form2.cs) (VB: [Form2.vb](./VB/GridPrinting/Form2.vb))**
<!-- default file list end -->
# How to customize PrintDialog and show the default .Net PrintDialog


<p>This example illustrates how to customize PrintDialog in PrintPreview.</p>
<p> </p>
<p>Note :</p>
<p>To show the default .Net Print Dialog instead of our PrintDialog, execute the following code :</p>
<p> </p>


```cs
PrintDialogRunner.Instance = new SystemPrintDialogRunner();
```


<p> </p>

<br/>


