   M S B A M L   `   `   `  ????F  BCoco_Master, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Coco_MasterCoco_Master  5   	       Coco_Master.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a;Icons-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   <d2http://schemas.microsoft.com/expression/blend/2008   5   	   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5   	   'localclr-namespace:Coco_Master   5   	   -   5        $	??720??5	   	   $
??1000??5
   	     ? WindowStartupLocation$  CenterScreen=?5   	    ? WindowState$ 	Maximized=?5   	   
??????  ? 
ResizeMode$ CanResizeWithGrip=?5   	    ? 	Resources 5         	BoolToVis??%   &	        ?? 5   
   6'   5      .??5      ?? -   5         ??Name$ border??5      
???????
??? ? ?._?5   
   ?  ? ColumnDefinitions 5      ?? 5      $	??200 ?6#   ?? 5      $??* ?6#   .+?5      ?  ? RowDefinitions 5       ?? 5!      $
??auto ?6$   ?? 5"      $??* ?6$   .+?5+      ?? $??1??6   ???	#FF2A9BB4 ?? CornerRadius$ 0 50 0 0??6=   $??0 45 0 0q?6U   ._?5,      ]? .+?5/      ?? $??80??6!   $??80??6,    ?? Padding$ 3q?68   ???	#FFE6E6E6$	 100??6[   $	??Top=?50   !   $
??Left=?66   $??
20 -30 0 0q?6Q   ._?51      A? ??52   "   ?? 53   &   	 ?? ImageSource$	 /Images/Asset 1.png??61   55      56      ?? 59      $??Coco Master??6$   
???????$??22(?6J   $??SemiBold"?6X   $	??Top=?5:   $   
 ?? TextAlignment$
 Center=?69   $??	5 25 2 10q?6P   ?? 5<      -   5         ??Name$ txtUser??5<   $   $	??Top=?65   
?????? 
???????$??Center=?5=   $   $??Center=?6A   $??5 0 2 10q?5>       $??SemiBold"?62   $??15(?6H   $??22??6V   ?? 5B      $??
25 10 25 0q?6$   $	??Top=?68   $	??0.8??6M   ???#7e5fdc6Z   ?? 5E      $	??Top=?6%   .+?5F      ?? -   5         ??Name$ btnHome??5F   %     menuButtons#??[ 66   $??30??6q   $??24??6|   $
??Left=?5G   %   $??4,5,0,3q?6@   .??5H   "   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ HomeVariant=?69   $??6,0,0,0q?6L   5I      ?? 5K      -   5        $ btnEmployees??5K   %   #??[ 6;   .??5L   "   ??  ?? Orientation$ 
Horizontal=?6-   .+?5M   &     $ AccountMultipleOutline=?6=     menuButtonIcon#??[ 6[   ?? 5N   &   $??	Employees??60   5O   #   5P      ?? 5R      -   5        $ btnCustomers??5R   %   #??[ 6;   .??5S   "   ?? $ 
Horizontal=?6-   .+?5T   &     $ AccountMultipleOutline=?6=   #??[ 6[   ?? 5U   &   $??	Customers??60   5V   #   5W      ?? 5Z      -   5        $ btnCoconutCategory??5Z   %   #??[ 6A   .??5[   "   ?? $ 
Horizontal=?6-   .+?5\   &     $ SeedOutline=?6=   #??[ 6P   ?? 5]   &   $??Coconut Category??60   5^   #   5_      ?? 5a      -   5        $ btnCoconutSales??5a   %   #??[ 6>   .??5b   "   ?? $ 
Horizontal=?6-   .+?5c   &     $ SeedOutline=?6=   #??[ 6P   ?? 5d   &   $??Coconut Sales??60   5e   #   5f      ?? 5h      -	   5        $ btnHusk??5h   %   #??[ 66   .??5i   "   ?? $ 
Horizontal=?6-   .+?5j   &     $
 Leaf=?6=   #??[ 6I   ?? 5k   &   $
??Husk??60   5l   #   5m      ?? 5o      -
   5        $ btnHuskProduction??5o   %   #??[ 6@   .??5p   "   ?? $ 
Horizontal=?6-   .+?5q   &     $
 Leaf=?6=   #??[ 6I   ?? 5r   &   $??Husk Production??60   5s   #   5t      ?? 5v      -   5        $ btnHuskSales??5v   %   #??[ 6;   .??5w   "   ?? $ 
Horizontal=?6-   .+?5x   &     $
 Leaf=?6=   #??[ 6I   ?? 5y   &   $??
Husk Sales??60   5z   #   5{      ?? 5}      -   5        $ btnPurchases??5}   %   #??[ 6;   .??5~   "   ?? $ 
Horizontal=?6-   .+?5   &     $ CurrencyUsd=?6=   #??[ 6P   ?? 5?   &   $??	Purchases??60   5?   #   5?      ?? 5?      -   5        $ btnSuppliers??5?   %   #??[ 6;   .??5?   "   ?? $ 
Horizontal=?6-   .+?5?   &     $ AccountOutline=?6=   #??[ 6S   ?? 5?   &   $??	Suppliers??60   5?   #   5?      5?      ?? 5?      -   5        $ btnAbout??5?   !   #??[ 63   $??Bottom=?6X   $
??Left=?6s   $??	10 0 0 10q?6?    ? ToolTip$ About??6?   .??5?        $ InformationOutline=?65   #??[ 6O   5?      ?? 5?      -   5        $ 	btnLogout??5?   !   #??[ 64   $??Bottom=?6Y   $??Right=?6t   $??Right=?6?   $??0 0 7 10q?5?   !   $ Logout??63   .??5?        $ Logout=?65   #??[ 6C   5?      5?      5?      5?      ? 5?      $??1??6   .+?5?      ?? $??0??6   ._?5?      ? $??0 0 10 3q?6   .+?5?       ? -   5          ?Name$
 main??5?       
???????  ? NavigationUIVisibility$ Hidden=?6A   ?? 5?      -   5         ??Name$ rr??5?       $??40q?6,   $F??@/coconut-milk-splashing-isolated-green-background_33736-3312.jpg??68   $
??Fill=?6?    J? RenderTransformOrigin$ 0.5,0.5&?6?   z?5?      V? 5?   "   .~?5?   &   ?? ?? 5?   &   ?? 5?   &   T? 5?   &    T? X$ -3Q?69   5?   #   5?      5?      5?      5?      5?      5?      5?      