   M S B A M L   `   `   `  ????F  BCoco_Master, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Coco_Master.Pages.CoconutPagesCoco_Master.Pages.CoconutPages  5      2    ,Coco_Master.Pages.CoconutPages.Coconut_Sales   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a;Icons-http://metro.mahapps.com/winfx/xaml/iconpacks   5      <d2http://schemas.microsoft.com/expression/blend/2008   5      :local,clr-namespace:Coco_Master.Pages.CoconutPages   5        N? 
Background
  ????? ? 	Resources 5         	BoolToVis??%   &	        ?? 5   
   6'   5      .??5      ?? ._?5   
   ? $??5q?6    ? RowDefinitions 5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $??* ?6    ?? 5      $
??auto ?6    .+?5,      ?? $??Coconut Sales??6   $??1??6-   $??32(?6:   $??SemiBold"?6H   $??0 20 0 0q?6^   $
??Left=?5-      ???#12151867   ?? 50      $??1??6   $??3??6#   ???#dae2ea$??0 5 0 5q?6E   ? 5C      $??2??6   .+?5D      ?? -   5         ??Name$ 
btnNewSale??5D        	addButton#??[ 6-   $??0,0,0,-2q?6P   .??5E      ??  ?? Orientation$ 
Horizontal=?6!   .+?5F      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=?61   $??Center=?6=   $??11??6X   $??11??6c   ?? 5G      $??Add new Sale??6$   5I      5J      5K      ?? 5N      $??Filter by Name??6   $??4??6.   $??13(?6;   $??SemiBold"?6I   $??	0 0 256 0q?6_   ???#121518$??Right=?5O   1   $??Center=?6M   ? 5S      $	??250??6   $??Right=?6   $??4??6;   .+?5U      ?? -   5        $ search??5U      #???  6)   $??35??6M   $??25??6X   $??0,0,43,0q?6d   $??Center=?6v   .??5V        $ Magnify=?6-   5W      ?? 5Y      -   5         ??Name$ txtboxFilter??5Y        textboxFilter#??[ 60   $??
0,10,80,10q?6W   $	??168??6k   5[      ?? 5]      -   5        $ btnBack??5]   "   $??4??6   #???  63   $??30??6W   $??25??6b   $??10 0 0 0q?6n   $??Center=?5^      $
??Left=?5_      $y?Hidden=?64   .??5`        $ LessThan=?6)   $??15??69   $??15??6D    ? ToolTip$ Go Back??6P   5a      &   System.Windows.Controls.DataGrid  5f      -   5          Name$ dgvSales??5f        DataGridStyle1#???  6)     DataGridCellStyle1	   	CellStyle#	 ?  6R     DataGridColumnHeaderStyle1
   ColumnHeaderStyle#
 ?  6?     DataGridRowStyle1   RowStyle# ?  6?   $??5??6?      Columns 5g      0  *System.Windows.Controls.DataGridTextColumn  5i      ,  &System.Windows.Controls.DataGridColumn   Header$ Sales ID??6)      
IsReadOnly$
 True??6;      CanUserResize$ False??6M      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6c   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6m   ?? *	SalesId+  5j      $ Coconut Category??6)   $
 True??6C   $ False??6U   $ * 6k    6u   ?? *CoconutCategoryID+  5k      $ Customer ID??6)   $
 True??6>   $ * 6P    6Z   ?? *
CustomerID+  5l      $ Sales Amount??6)   $
 True??6?   $ * 6Q    6[   ?? *SalesAmmount+  5m      $ Quantity??6)   $
 True??6;   $ * 6M    6W   ?? *
Quantity+  5n      $
 Date??6)   $
 True??67   $ * 6I    6S   ?? *
SaleDate+4  .System.Windows.Controls.DataGridTemplateColumn  5p      $ 
Operations??6-   $
 True??6A   $
 auto 6S      CellTemplate 5q      ?? 5r      .R?5s   "   ?? $ 
Horizontal=?6-   .+?5t   &   ?? $ btnEdit??6-   -   5          gridEditButton#??[ 5t   >   .??5u   *     $ PencilOutline=?6A     gridButtonIcon#??[ 6V   5v   '   ?? 5w   &   $ 	btnDelete??6-   -   5         	 gridRemoveButton#??[	 5w   p   $??5 0 0 0q?5x   -   $ Delete??6>   
 ? Tag 5w   X   ?? *	SalesId+.??5y   *     $ DeleteOutline=?6A   #??[ 6V   5z   '   5{   #   5|      5~      5?      5?      5?      5?      