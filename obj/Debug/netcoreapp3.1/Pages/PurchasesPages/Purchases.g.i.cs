﻿#pragma checksum "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2F6B800D13583E17B3CA5949D799DB785C0B05D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coco_Master.Pages.PurchasesPages;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace Coco_Master.Pages.PurchasesPages {
    
    
    /// <summary>
    /// Purchases
    /// </summary>
    public partial class Purchases : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 55 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddNewPurchase;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxFilter;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvPurchases;
        
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
            System.Uri resourceLocater = new System.Uri("/Coco_Master;component/pages/purchasespages/purchases.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
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
            this.btnAddNewPurchase = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
            this.btnAddNewPurchase.Click += new System.Windows.RoutedEventHandler(this.btnAddNewPurchase_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.search = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
            this.search.Click += new System.Windows.RoutedEventHandler(this.search_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtboxFilter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgvPurchases = ((System.Windows.Controls.DataGrid)(target));
            
            #line 90 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
            this.dgvPurchases.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgvPurchases_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 104 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 107 "..\..\..\..\..\Pages\PurchasesPages\Purchases.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
