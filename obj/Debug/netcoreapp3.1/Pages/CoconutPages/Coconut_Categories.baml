   M S B A M L   `   `   `  ????F  BCoco_Master, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Coco_Master.Pages.CoconutPagesCoco_Master.Pages.CoconutPages  5      7    1Coco_Master.Pages.CoconutPages.Coconut_Categories   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a;Icons-http://metro.mahapps.com/winfx/xaml/iconpacks   5      <d2http://schemas.microsoft.com/expression/blend/2008   5      :local,clr-namespace:Coco_Master.Pages.CoconutPages   5        N? 
Background
  ????? ? 	Resources 5         	BoolToVis??%   &	        ?? 5   
   6'   5      .??5      ?? ._?5   
   ? $??5q?6    ? RowDefinitions 5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $??* ?6    ?? 5      $
??auto ?6    .+?5      ?? $??Coconut Categories??6   $??1??62   $??32(?6?   $??SemiBold"?6M   $??0 20 0 0q?6c   $
??Left=?5       ???#12151867   ?? 5#      $??1??6   $??3??6#   ???#dae2ea$??0 5 0 5q?6E   ? 5(      $??2??6   .+?5)      ?? -   5         ??Name$ btnNewCategory??5)        	addButton#??[ 61   $??0,0,0,-2q?6T   .??5*      ??  ?? Orientation$ 
Horizontal=?6!   .+?5+      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=?61   $??Center=?6=   $??11??6X   $??11??6c   ?? 5,      $??Add new Category??6$   5.      5/      50      ?? 53      $??Filter by name??6   $??4??6.   $??13(?6;   $??SemiBold"?6I   $??	0,0,256,0q?6_   ???#121518$??Right=?54   1   $??Center=?6M   ? 58      $	??250??6   $??Right=?6   $??4??6;   .+?5:      ?? -   5        $ search??5:      #???  6)   $??35??6M   $??25??6X   $??0,0,43,0q?6d   $??Center=?5;      .??5<        $ Magnify=?6-   5=      ?? 5?      -   5         ??Name$ txtboxFilter??5?        textboxFilter#??[ 60   $??
0,10,80,10q?6W   $	??168??6k   5B      ?? 5H      -   5        $ btnBack??5H   "   $??4??6   #???  63   $??30??6W   $??25??6b   $??10 0 0 0q?6n   $??Center=?5I      $
??Left=?5J      $y?Hidden=?64   .??5K        $ LessThan=?6)   $??15??69   $??15??6D    ? ToolTip$ Go Back??6P   5L      &   System.Windows.Controls.DataGrid  5P      -   5          Name$ dgvCategories??5P        DataGridStyle1#???  6.     DataGridCellStyle1	   	CellStyle#	 ?  6W     DataGridColumnHeaderStyle1
   ColumnHeaderStyle#
 ?  6?     DataGridRowStyle1   RowStyle# ?  6?   $??5??6?      Columns 5Q      0  *System.Windows.Controls.DataGridTextColumn  5S      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6)      
IsReadOnly$
 True??65      CanUserResize$ False??6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   ?? *Id+  5T      $
 Name??6)   $
 True??67   $ * 6J    6T   ?? *Name+  5U      $ Stocks??6)   $
 True??69   $ * 6K    6U   ?? *Stocks+  5V      $ 
Unit Price??6)   $
 True??6=   $ * 6O    6Y   ?? *	UnitPrice+4  .System.Windows.Controls.DataGridTemplateColumn  5Y      $ 
Operations??6-   $
 True??6A   $
 auto 6S      CellTemplate 5Z      ?? 5[      .R?5\   "   ?? $ 
Horizontal=?6-   .+?5]   &   ?? $ btnEdit??6-   -   5          gridEditButton#??[ 5]   >   .??5^   *     $ PencilOutline=?6A     gridButtonIcon#??[ 6V   5_   '   ?? 5`   &   $ 	btnDelete??6-   -   5         	 gridRemoveButton#??[	 5`   k   $??5 0 0 0q?5a   -   $ Delete??6>   
 ? Tag 5`   X   ?? *Id+.??5b   *     $ DeleteOutline=?6A   #??[ 6V   5c   '   5d   #   5e      5g      5j      5?      5?      5?      