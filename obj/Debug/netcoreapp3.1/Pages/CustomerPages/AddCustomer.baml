   M S B A M L   `   `   `  ????F  BCoco_Master, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Coco_Master.Pages.CustomerPagesCoco_Master.Pages.CustomerPages  5   	   1    +Coco_Master.Pages.CustomerPages.AddCustomer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a;Icons-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   <d2http://schemas.microsoft.com/expression/blend/2008   5   	   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5   	   ;local-clr-namespace:Coco_Master.Pages.CustomerPages   5   	     ? Title$  AddCustomer??5	   	    ? WindowStyle$
 None=?5
   	    ? 
ResizeMode$ NoResize=?5   	   
??????  ? WindowStartupLocation$ CenterScreen=?5   	    ? AllowsTransparency$
 True??5   	   $	??500??5   	   $	??450??6   .??5      ??  ?? CornerRadius$ 5??6   
???????
???? ??$??1q?6F   ._?5   
   ?  ? RowDefinitions 5      ?? 5      $??30 ?6    ?? 5      $??* ?6    .+?5      ? $??0??6    ? ColumnDefinitions 5      ?? 5      $??* ?6'   ?? 5      $??30 ?6'   .+?5      ? -   5        $??0??5      .+?5       ?? $??Add New Customer??6    
???????$??20,0,0,0q?6J   $
??Left=?6\   $??Center=?6w   $
??Bold"?6?   $??15(?6?   $??Arial)?6?   $	??428??6?   5"      ?? 5$      -   5         ??Name$ btnClose??5$      $??1??6+      ButtonStyle1#???   6;   $??20??6c   $??20??6n   	 ? ToolTip$	 Close??5%   0   5'      ? 5+      $??1??6    5,      ?? 5-      $
??auto ?6$   ?? 5.      $??* ?6$   .+?51      ?? $??
15,15,15,0q?6   $??Disabled=?62   .+?53      ??   TextBlockStyle1#???  6    $??ID : ??6J   $??12q?6W   $	??100??6c   $
??Left=?6o   
???????$??Calibri)?6?   ?? 54      -   5        
 ??Name$
 txtId??54        TextBoxStyle1#???  6-   $??*??55   <   
???  ??6v   ?? 5:      #???  6    $??Full Name : ??6J   $??12q?6^   $	??100??6j   $
??Left=?6v   
???????$??Calibri)?6?   ?? 5;      -   5        $
 txtName??5;      #???  6/   $??*??5<   \   
???  ??6e   ?? 5>      #???  6    $??Type : ??6J   $??12q?6Y   $	??100??6e   $
??Left=?6q   
???????$??Calibri)?6?   ?? 5?      -   5        $??cmbType??5?        ComboBoxStyle1#???  6.   $	??400??6W   $??35??6c   $??Center=?6o   $??5 0 0 0q?6?   .@?5A      ?? $??Type1??6'   ?? 5B      $??Type2??6'   ?? 5C      $??Type3??6'   ?? 5D      $??Type4??6'   5E      ?? 5G      #???  6    $??Contact No. : ??6J   $??12q?6`   $	??100??6l   $
??Left=?6x   
???????$??Calibri)?6?   ?? 5H      -   5        $
 
txtContact??5H      #???  62   $??*??5I   _   
???  ??6y   ?? 5K      #???  6    $??
Address : ??6J   $	??12 q?6\   $	??100??6i   $
??Left=?6u   
???????$??Calibri)?6?   ?? 5L      -   5        $??
txtAddress??5L      #???  60   $
??Left=?6Y   5N      ? 5R      $??1??6   $??Center=?6)   $??Center=?6F   $??
224,17,0,0q?6a   .+?5S      ?? -   5        $ btnSave??5S        
Save/Clear#???  6.   $
??Save??6S   $??0,0,20,0q?6b   $??60??6t   $??25??6   6?   ?? 5T      -	   5        $ btnClear??5T      #???  6/   $??Clear??6T   $??60??6d   $??25??6o   6{   ?? 5U      $??
* Required??6   $??8(?61   
???  ??$??Right=?6O   $??9,0,0,0q?6k   5V      5X      5Z      5[      5]      