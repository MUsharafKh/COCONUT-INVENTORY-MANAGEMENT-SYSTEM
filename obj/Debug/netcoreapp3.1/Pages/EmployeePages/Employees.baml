   M S B A M L   `   `   `  ????F  BCoco_Master, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Coco_Master.Pages.EmployeePagesCoco_Master.Pages.EmployeePages  5      /    )Coco_Master.Pages.EmployeePages.Employees   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a;Icons-http://metro.mahapps.com/winfx/xaml/iconpacks   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      <d2http://schemas.microsoft.com/expression/blend/2008   5      ;local-clr-namespace:Coco_Master.Pages.EmployeePages   5        N? 
Background
  ????? N? Title$ 	Employees??5       ? 	Resources 5         	BoolToVis??%   &	        ?? 5   
   6'   5      .??5      ?? ._?5   
   ? $??5q?6    ? RowDefinitions 5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $??* ?6    ?? 5      $
??auto ?6    .+?5      ?? $??	Employees??6   $??1??6)   $??32(?66   $??SemiBold"?6D   $??0 20 0 0q?6Z   $
??Left=?5       ???#12151867   ?? 5$      $??1??6   $??3??6#   ???#dae2ea$??0 5 0 5q?6E   ?? 5'      $??2??6    ?? Orientation$ 
Horizontal=?6&   $??Right=?6?   .+?5(      ?? -   5         ??Name$ btnAdd??5(   &   $??2??6     	addButton#??[ 66    ? Cursor$
 Hand??6Y   $??0,0,8,0q?6|   .??5)      ?? $ 
Horizontal=?6!   .+?5*      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=?61   $??Center=?6=   $??11??6X   $??11??6c   $??0,1,8,3q?6o   ?? 5+      $??Add new employee??6$   5-      5.      51      ?? 55      $?? ??6   $??4??6    $??13(?6-   $??SemiBold"?6;   $??	0,0,256,0q?6Q   ???#121518$??Right=?56   1   $??Center=?6M   ? 5:      $	??250??6   $??Right=?6   $??4??6;   .+?5<      ?? -   5        $ search??5<      #???  6)   $??35??6M   $??25??6X   $??0,0,43,0q?6d   $??Center=?6v   .??5=        $ Magnify=?6-   5>      ?? 5@      -   5         ??Name$ txtboxFilter??5@        textboxFilter#??[ 61   $??
0,10,80,10q?6X   $	??168??6l   5B      ?? 5D      -   5        $ btnBack??5D   "   $??4??6   #???  63   $??30??6W   $??25??6b   $??10 0 0 0q?6n   $??Center=?6?   $
??Left=?5E      $y?Hidden=?64   .??5F        $ LessThan=?6)   $??15??69   $??15??6D   	 ? ToolTip$	 Go Back??6P   5G      ?? 5I      $??Filter by Name??6   $??4??6.   $??13(?6;   $??SemiBold"?6I   $??	0,0,256,0q?6_   ???#121518$??Right=?5J   1   $??Center=?6M   &   System.Windows.Controls.DataGrid  5O      -   5        
  Name$
 dgvEmployees??5O   ?     DataGridStyle1#???  6     DataGridCellStyle1   	CellStyle# ?  6@     DataGridColumnHeaderStyle1   ColumnHeaderStyle# ?  6q     DataGridRowStyle1   RowStyle# ?  6?   $??5??6?      Columns 5P      0  *System.Windows.Controls.DataGridTextColumn  5Y      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6)      
IsReadOnly$
 True??65      CanUserResize$ False??6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6h   ?? *
EmployeeId+  5Z      $
 Name??6)   $
 True??67   $ False??6I   $ * 6_    6i   ?? *EmployeeName+  5[      $
 Type??6)   $
 True??67   $ * 6I    6S   ?? *EmplyeeType+  5\      $ Salary??6)   $
 True??69   $ * 6K    6U   ?? *EmployeeSalary+  5]      $ Phone Number??6)   $
 True??6?   $ * 6Q    6[   ?? *EmployeeContact+  5^      $ Adress??6)   $
 True??69   $ * 6K    6U   ?? *EmployeeAddress+4  .System.Windows.Controls.DataGridTemplateColumn  5`      $ 
Operations??6-   $
 True??6A   $
 auto 6S      CellTemplate 5a      ?? 5b      .R?5c   "   ?? $ 
Horizontal=?6-   .+?5d   &   ?? $ btnEdit??6-   -   5          gridEditButton#??[ 5d   ?   $
	 Edit??6?   
 ? Tag 6g   ?? *
EmployeeId+.??5e   *     $ PencilOutline=?6A     gridButtonIcon#??[ 6V   5f   '   ?? 5g   &   $ 	btnDelete??6-   -   5         	 gridRemoveButton#??[	 5g   s   $??5 0 0 0q?5h   -   $	 Delete??6>    5g   X   ?? *
EmployeeId+.??5i   *     $ DeleteOutline=?6A   #??[ 6V   5j   '   5k   #   5l      5n      5q      5t      5u      5v      