   M S B A M L   `   `   `  ????F  BCoco_Master, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Coco_Master.Pages.PurchasesPages Coco_Master.Pages.PurchasesPages  5   	   5    /Coco_Master.Pages.PurchasesPages.AddNewPurchase   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Coco_Master.Pages.PurchasesPages     5   	     ? Title$  AddNewPurchase??5   	    ? WindowStyle$
 None=?5	   	    ? 
ResizeMode$ NoResize=?5
   	   
??????  ? WindowStartupLocation$ CenterScreen=?5   	    ? AllowsTransparency$
 True??5   	   $	??520??5   	   $	??450??6   .??5      ??  ?? CornerRadius$ 5??6   
???????
???? ??$??1q?6F   ._?5   
   ?  ? RowDefinitions 5      ?? 5      $??30 ?6    ?? 5      $??* ?6    .+?5      ? $??0??6    ? ColumnDefinitions 5      ?? 5      $??* ?6'   ?? 5      $??30 ?6'   .+?5      ? -   5        $??0??5      .+?5      ?? $??Add New Purchase??6    
???????$??20,0,0,0q?6J   $
??Left=?6\   $??Center=?6w   $
??Bold"?6?   $??15(?6?   $??Arial)?6?   $	??428??6?   5!      ?? 5#      -   5         ??Name$ btnClose??5#      $??1??6+      ButtonStyle1#???   6;   $??20??6c   $??20??6n   	 ? ToolTip$	 Close??5$   0   5&      ? 5*      $??1??6    5+      ?? 5,      $
??auto ?6$   ?? 5-      $??* ?6$   .+?50      ?? $??
15,15,15,0q?6   $??Disabled=?62   .+?52      ??   TextBlockStyle1#???  6    $??ID : ??6J   $??12q?6W   $	??100??6c   $
??Left=?6o   
???????$??Calibri)?53   2   ?? 54      -   5        
 ??Name$
 txtId??54        TextBoxStyle1#???  6-   $??*??6?   
???  ??6?   ?? 56      #???  6    $??Supleir Id : ??6J   $??12q?6_   $	??100??6k   $
??Left=?6w   
???????$??Calibri)?57   2   ?? 58      -   5        $
 txtSupleirId??58      #???  64   $??*??59   f   
???  ??6o   ?? 5;      #???  6    $??Coconut Category ID : ??6J   $??12q?6h   $
??auto??6t   $
??Left=?6?   
???????$??Calibri)?6?   ?? 5<      -   5        $
 txtCoconutCategoryID??5<      #???  6<   $??*??5=   v   
???  ??6   ?? 5?      #???  6    $??Purchase Ammount : ??6J   $??12q?6e   $
??auto??6q   $
??Left=?6~   
???????$??Calibri)?6?   ?? 5@      -   5        $
 txtPurchaseAmmount??5@      #???  6:   $??*??5A   r   
???  ??6{   ?? 5C      #???  6    $??Quantity : ??6J   $??12q?6]   $	??100??6i   $
??Left=?6u   
???????$??Calibri)?6?   ?? 5D      -   5        $
 txtQuantity??5D      #???  63   $??*??5E   d   
???  ??6m   5H      ? 5L      $??1??6   $??Center=?6)   $??Center=?6F   $??
224,17,0,0q?6a   .+?5M      ?? -   5        $ btnSave??5M        
Save/Clear#???  6.   $
??Save??6S   $??0,0,20,0q?6b   $??60??6t   $??25??6   5N      ?? 5O      -	   5        $ btnClear??5O      #???  6/   $??Clear??6T   $??60??6d   $??25??6o   6{   ?? 5P      $??
* Required??6   $??8(?61   
???  ??$??Right=?6O   $??9,0,0,0q?6k   5Q      5S      5U      5V      5W      