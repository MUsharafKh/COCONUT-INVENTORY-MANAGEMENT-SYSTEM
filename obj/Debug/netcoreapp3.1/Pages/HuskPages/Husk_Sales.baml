   M S B A M L   `   `   `  ????F  BCoco_Master, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Coco_Master.Pages.HuskPagesCoco_Master.Pages.HuskPages  5      ,    &Coco_Master.Pages.HuskPages.Husk_Sales   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a;Icons-http://metro.mahapps.com/winfx/xaml/iconpacks   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      <d2http://schemas.microsoft.com/expression/blend/2008   5      7local)clr-namespace:Coco_Master.Pages.HuskPages   5        N? 
Background
  ????? ? 	Resources 5         	BoolToVis??%   &	        ?? 5   
   6'   5      .??5      ?? ._?5   
   ? $??5q?6    ? RowDefinitions 5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $??* ?6    ?? 5      $
??auto ?6    .+?5,      ?? $??
Husk Sales??6   $??1??6*   $??32(?67   $??SemiBold"?6E   $??0 20 0 0q?6[   $
??Left=?5-      ???#12151867   ?? 50      $??1??6   $??3??6#   ???#dae2ea$??0 5 0 5q?6E   ? 54      $??2??6   5=      ? 5A      $??2??6   .+?5B      ?? -   5         ??Name$ 
btnNewSale??5B        	addButton#??[ 6-   $??0,0,0,-2q?6P   .??5C      ??  ?? Orientation$ 
Horizontal=?6!   .+?5D      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=?61   $??Center=?6=   $??11??6X   $??11??6c   ?? 5E      $??Add new Sale??6$   5G      5H      5I      ?? 5K      $??Filter by Name??6   $??4??6.   $??13(?6;   $??SemiBold"?6I   $??	0 0 256 0q?6_   ???#121518$??Right=?5L   1   $??Center=?6M   ? 5P      $	??250??6   $??Right=?6   $??4??6;   .+?5R      ?? -   5        $ search??5R      #???  6)   $??35??6M   $??25??6X   $??0,0,43,0q?6d   $??Center=?6v   .??5S        $ Magnify=?6-   5T      ?? 5V      -   5         ??Name$ txtboxFilter??5V        textboxFilter#??[ 60   $??
0,10,80,10q?6W   $	??168??6k   5X      ?? 5Z      -   5        $ btnBack??5Z   "   $??4??6   #???  63   $??30??6W   $??25??6b   $??10 0 0 0q?6n   $??Center=?5[      $
??Left=?5\      $y?Hidden=?64   .??5]        $ LessThan=?6)   $??15??69   $??15??6D    ? ToolTip$ Go Back??6P   5^      &   System.Windows.Controls.DataGrid  5c      -   5          Name$ dgvHuskSales??5c        DataGridStyle1#???  6-     DataGridCellStyle1	   	CellStyle#	 ?  6V     DataGridColumnHeaderStyle1
   ColumnHeaderStyle#
 ?  6?     DataGridRowStyle1   RowStyle# ?  6?   $??5??6?      Columns 5d      0  *System.Windows.Controls.DataGridTextColumn  5g      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6*      
IsReadOnly$
 True??66      CanUserResize$ False??6H      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6h   ?? *id+  5h      $ Customer id??6)   $
 True??6>   $ * 6P    6Z   ?? *
CustomerID+  5i      $ HUSK ID??6)   $
 True??6:   $ * 6L    6V   ?? *HuskId+  5j      $ 
UNIT PRICE??6)   $
 True??6=   $ * 6O    6Y   ?? *	UnitPrice+  5k      $ QUANTITY??6)   $
 True??6;   $ * 6M    6W   ?? *
Quantity+  5l      $ TOTAL??6)   $
 True??68   $ * 6J    6T   ?? *Total+  5m      $ 	SALE DATE??6)   $
 True??6<   $ * 6N    6X   ?? *	SalesDate+4  .System.Windows.Controls.DataGridTemplateColumn  5o      $ 
Operations??6-   $
 True??6A   $
 auto 6S      CellTemplate 5p      ?? 5q      .R?5r   "   ?? $ 
Horizontal=?6-   .+?5s   &   ?? $ btnEdit??6-   -   5          gridEditButton#??[ 5s   T   .??5t   *     $ PencilOutline=?6A     gridButtonIcon#??[ 6V   5u   '   ?? 5v   &   $ 	btnDelete??6-   -   5         	 gridRemoveButton#??[	 5v   k   $??5 0 0 0q?5w   -   $ Delete??6>   
 ? Tag 5v   X   ?? *id+.??5x   *     $ DeleteOutline=?6A   #??[ 6V   5y   '   5z   #   5{      5}      5?      5?      5?      5?      