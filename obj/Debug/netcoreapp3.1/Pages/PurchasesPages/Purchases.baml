   M S B A M L   `   `   `  ????F  BCoco_Master, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Coco_Master.Pages.PurchasesPages Coco_Master.Pages.PurchasesPages  5      0    *Coco_Master.Pages.PurchasesPages.Purchases   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a;Icons-http://metro.mahapps.com/winfx/xaml/iconpacks   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      <d2http://schemas.microsoft.com/expression/blend/2008   5      <local.clr-namespace:Coco_Master.Pages.PurchasesPages   5        N? 
Background
  ????? ? 	Resources 5         	BoolToVis??%   &	        ?? 5   
   6'   5      .??5      ?? ._?5   
   ? $??5q?6    ? RowDefinitions 5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $??* ?6    ?? 5      $
??auto ?6    .+?5,      ?? $??	Purchases??6   $??1??6)   $??32(?66   $??SemiBold"?6D   $??0 20 0 0q?6Z   $
??Left=?5-      ???#12151867   ?? 50      $??1??6   $??3??6#   ???#dae2ea$??0 5 0 5q?6E   ? 54      $??2??6   .+?57      ?? -   5         ??Name$ btnAddNewPurchase??57   M     	addButton#??[ 6   $??0,0,0,0q?6<   .??58      ??  ?? Orientation$ 
Horizontal=?6!   .+?59      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=?61   $??Center=?6=   $??11??6X   $??11??6c   $??0 1 8 0q?6o   ?? 5:      $??Add new Purchase??6$   5<      5=      5>      ?? 5A      $??Filter by Name??6   $??4??6.   $??13(?6;   $??SemiBold"?6I   $??	0 0 256 0q?6_   ???#121518$??Right=?5B   1   $??Center=?6M   ? 5F      $	??250??6   $??Right=?6   $??4??6;   .+?5H      ?? -   5        $ search??5H      #???  6)   $??35??6M   $??25??6X   $??0,0,43,0q?6d   $??Center=?6v   .??5J        $ Magnify=?6-   5K      ?? 5M      -   5         ??Name$ txtboxFilter??5M        textboxFilter#??[ 60   $??
0,10,80,10q?6W   $	??168??6k   5O      ?? 5Q      -   5        $ btnBack??5Q   "   $??4??6   #???  63   $??30??6W   $??25??6b   $??10 0 0 0q?6n   $??Center=?5R      $
??Left=?5S      $y?Hidden=?64   .??5T        $ LessThan=?6)   $??15??69   $??15??6D    ? ToolTip$ Go Back??6P   5U      &   System.Windows.Controls.DataGrid  5Z      -   5          Name$ dgvPurchases??5Z        DataGridStyle1#???  6-     DataGridCellStyle1	   	CellStyle#	 ?  6V     DataGridColumnHeaderStyle1
   ColumnHeaderStyle#
 ?  6?     DataGridRowStyle1   RowStyle# ?  6?   $??5??6?      Columns 5[      0  *System.Windows.Controls.DataGridTextColumn  5]      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6)      
IsReadOnly$
 True??65      CanUserResize$ False??6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   ?? *Id+  5^      $ Supplier Id??6)   $
 True??6>   $ False??6P   $ * 6f    6p   ?? *	SupleirId+  5_      $ Coconut Category Id??6)   $
 True??6F   $ False??6X   $ * 6n    6x   ?? *CoconutCategoryID+  5`      $ Purchase Amount??6)   $
 True??6B   $ * 6T    6^   ?? *PurchaseAmmount+  5a      $ Quantity??6)   $
 True??6;   $ * 6M    6W   ?? *
Quantity+  5b      $
 Date??6)   $
 True??67   $ * 6I    6S   ?? *PurchaseDate+4  .System.Windows.Controls.DataGridTemplateColumn  5d      $ 
Operations??6-   $
 True??6A   $
 auto 6S      CellTemplate 5e      ?? 5f      .R?5g   "   ?? $ 
Horizontal=?6-   .+?5h   &   ?? $ btnEdit??6-   -   5          gridEditButton#??[ 5h   T   .??5i   *     $ PencilOutline=?6A     gridButtonIcon#??[ 6V   5j   '   ?? 5k   &   $ 	btnDelete??6-   -   5         	 gridRemoveButton#??[	 5k   k   $??5 0 0 0q?5l   -   $ Delete??6>   
 ? Tag 5k   X   ?? *Id+.??5m   *     $ DeleteOutline=?6A   #??[ 6V   5n   '   5o   #   5p      5r      5u      5?      5?      5?      