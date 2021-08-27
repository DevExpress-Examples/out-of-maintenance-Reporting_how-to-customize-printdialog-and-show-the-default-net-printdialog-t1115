<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597395/13.2.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T111587)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


