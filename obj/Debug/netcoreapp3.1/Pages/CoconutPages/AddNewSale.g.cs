#pragma checksum "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DBC2DE43FDBD5273CFAB7F29164E14A80B3CB097"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coco_Master.Pages.CoconutPages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Coco_Master.Pages.CoconutPages {
    
    
    /// <summary>
    /// AddNewSale
    /// </summary>
    public partial class AddNewSale : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCategoryId;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerID;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSalesAmmount;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantity;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Coco_Master;component/pages/coconutpages/addnewsale.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 30 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.txtId.GotFocus += new System.Windows.RoutedEventHandler(this.txtId_GotFocus);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.txtId.LostFocus += new System.Windows.RoutedEventHandler(this.txtId_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtCategoryId = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.txtCategoryId.GotFocus += new System.Windows.RoutedEventHandler(this.txtCategoryId_GotFocus);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.txtCategoryId.LostFocus += new System.Windows.RoutedEventHandler(this.txtCategoryId_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtCustomerID = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.txtCustomerID.GotFocus += new System.Windows.RoutedEventHandler(this.txtCustomerID_GotFocus);
            
            #line default
            #line hidden
            
            #line 62 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.txtCustomerID.LostFocus += new System.Windows.RoutedEventHandler(this.txtCustomerID_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtSalesAmmount = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.txtSalesAmmount.GotFocus += new System.Windows.RoutedEventHandler(this.txtSalesAmmount_GotFocus);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.txtSalesAmmount.LostFocus += new System.Windows.RoutedEventHandler(this.txtSalesAmmount_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtQuantity = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.txtQuantity.GotFocus += new System.Windows.RoutedEventHandler(this.txtQuantity_GotFocus);
            
            #line default
            #line hidden
            
            #line 70 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.txtQuantity.LostFocus += new System.Windows.RoutedEventHandler(this.txtQuantity_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\..\Pages\CoconutPages\AddNewSale.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.btnClear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

