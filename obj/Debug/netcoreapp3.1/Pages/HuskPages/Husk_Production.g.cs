﻿#pragma checksum "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48A7AB4BFF1E15017A0E7E8F95CEC2135DFCA1FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coco_Master.Pages.HuskPages;
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


namespace Coco_Master.Pages.HuskPages {
    
    
    /// <summary>
    /// Husk_Production
    /// </summary>
    public partial class Husk_Production : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 66 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewProduction;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxFilter;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvHuskProduction;
        
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
            System.Uri resourceLocater = new System.Uri("/Coco_Master;component/pages/huskpages/husk_production.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
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
            this.btnNewProduction = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
            this.btnNewProduction.Click += new System.Windows.RoutedEventHandler(this.btnNewProduction_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.search = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.txtboxFilter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgvHuskProduction = ((System.Windows.Controls.DataGrid)(target));
            
            #line 99 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
            this.dgvHuskProduction.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgvHuskProduction_SelectionChanged);
            
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
            
            #line 115 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 118 "..\..\..\..\..\Pages\HuskPages\Husk_Production.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
