   M S B A M L   `   `   `  ????F  BCoco_Master, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Coco_Master.Pages.CustomerPagesCoco_Master.Pages.CustomerPages  5      /    )Coco_Master.Pages.CustomerPages.Customers   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a;Icons-http://metro.mahapps.com/winfx/xaml/iconpacks   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      <d2http://schemas.microsoft.com/expression/blend/2008   5      ;local-clr-namespace:Coco_Master.Pages.CustomerPages   5        N? 
Background
  ????? ? 	Resources 5         	BoolToVis??%   &	        ?? 5   
   6'   5      .??5      ?? ._?5   
   ? $??5q?6    ? RowDefinitions 5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $??* ?6    ?? 5      $
??auto ?6    .+?5,      ?? $??	Customers??6   $??1??6)   $??32(?66   $??SemiBold"?6D   $??0 20 0 0q?6Z   $
??Left=?5-      ???#12151867   ?? 50      $??1??6   $??3??6#   ???#dae2ea$??0 5 0 5q?6E   ?? 55      $??2??6    ?? Orientation$ 
Horizontal=?6&   $??Right=?6?   .+?56      ?? -   5         ??Name$ btnAdd??56   &   $??2??6     	addButton#??[ 66    ? Cursor$
 Hand??6Y   $??0,0,8,0q?6|   .??57      ?? $ 
Horizontal=?6!   .+?58      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=?61   $??Center=?6=   $??11??6X   $??11??6c   $??0,1,8,3q?6o   ?? 59      $??Add new customer??6$   5;      5<      5>      ?? 5D      $??Filter by Name??6   $??4??6.   $??13(?6;   $??SemiBold"?6I   $??	0,0,256,0q?6_   ???#121518$??Right=?5E   1   $??Center=?6M   ? 5I      $	??250??6   $??Right=?6   $??4??6;   .+?5K      ?? -   5        $ search??5K      #???  6)   $??35??6M   $??25??6X   $??0,0,43,0q?6d   $??Center=?6v   .??5L        $ Magnify=?6-   5M      ?? 5O      -   5         ??Name$ txtboxFilter??5O        textboxFilter#??[ 60   $??
0,10,80,10q?6W   $	??168??6k   5Q      ?? 5S      -   5        $ btnBack??5S   "   $??4??6   #???  63   $??30??6W   $??25??6b   $??10 0 0 0q?6n   $??Center=?5T      $
??Left=?5U      $y?Hidden=?64   .??5V        $ LessThan=?6)   $??15??69   $??15??6D    ? ToolTip$ Go Back??6P   5W      &   System.Windows.Controls.DataGrid  5\      -   5        	  Name$	 dgvCustomer??5\        DataGridStyle1#???  6,     DataGridCellStyle1
   	CellStyle#
 ?  6U     DataGridColumnHeaderStyle1   ColumnHeaderStyle# ?  6?     DataGridRowStyle1   RowStyle# ?  6?   $??5??6?      Columns 5]      0  *System.Windows.Controls.DataGridTextColumn  5_      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6)      
IsReadOnly$
 True??65      CanUserResize$ False??6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   ?? *
CustomerId+  5`      $
 Name??6)   $
 True??67   $ * 6I    6S   ?? *CustomerName+  5a      $
 Type??6)   $
 True??67   $ * 6I    6S   ?? *CustomerType+  5b      $ Phone Number??6)   $
 True??6?   $ * 6Q    6[   ?? *CustomerPhone+  5c      $ Adress??6)   $
 True??69   $ * 6K    6U   ?? *CustomerAddress+4  .System.Windows.Controls.DataGridTemplateColumn  5e      $ 
Operations??6-   $
 True??6A   $
 auto 6S      CellTemplate 5f      ?? 5g      .R?5h   "   ?? $ 
Horizontal=?6-   .+?5i   &   ?? $ btnEdit??6-   -   5          gridEditButton#??[ 5i   >   
 ? Tag 6f   ?? *
CustomerId+.??5j   *     $ PencilOutline=?6A     gridButtonIcon#??[ 6V   5k   '   ?? 5l   &   $ 	btnDelete??6-   -   5         	 gridRemoveButton#??[	 5l   s   $??5 0 0 0q?5m   -   $ Delete??6>    5l   X   ?? *
CustomerId+.??5n   *     $ DeleteOutline=?6A   #??[ 6V   5o   '   5p   #   5q      5s      5v      5?      5?      5?      