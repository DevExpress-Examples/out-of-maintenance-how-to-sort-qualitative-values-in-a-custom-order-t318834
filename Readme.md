<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/CustomSortOrder/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomSortOrder/MainWindow.xaml))**
* [NumberComparer.cs](./CS/CustomSortOrder/NumberComparer.cs) (VB: [NumberComparer.vb](./VB/CustomSortOrder/NumberComparer.vb))
<!-- default file list end -->
# How to sort qualitative values in a custom order


This example demonstrates how to implement a custom qualitative scale sort order.


<h3>Description</h3>

To do this, assign an object of a class implementing the <strong>System.Collections.IComparer</strong> interface to the <strong>AxisBase.QualitativeScaleComparer</strong> property.

<br/>


