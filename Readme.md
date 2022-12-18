<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128570219/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T318834)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


