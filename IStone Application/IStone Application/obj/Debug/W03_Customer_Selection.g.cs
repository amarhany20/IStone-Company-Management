﻿#pragma checksum "..\..\W03_Customer_Selection.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01B68AED1F972E21C39C044E3AA4E072330F55494C3FB60D07B93C3A95A070D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IStone_Application;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace IStone_Application {
    
    
    /// <summary>
    /// W03_Customer_Selection
    /// </summary>
    public partial class W03_Customer_Selection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\W03_Customer_Selection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_Search;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\W03_Customer_Selection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Search;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\W03_Customer_Selection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid_Customers;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\W03_Customer_Selection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_SelectCustomer;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\W03_Customer_Selection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CreateANewCustomer;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\W03_Customer_Selection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Close;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\W03_Customer_Selection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_SearchByDate;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\W03_Customer_Selection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Count;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\W03_Customer_Selection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_SearchByFirstLetter;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/IStone Application;component/w03_customer_selection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\W03_Customer_Selection.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textbox_Search = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.button_Search = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\W03_Customer_Selection.xaml"
            this.button_Search.Click += new System.Windows.RoutedEventHandler(this.button_Search_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.datagrid_Customers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.button_SelectCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\W03_Customer_Selection.xaml"
            this.button_SelectCustomer.Click += new System.Windows.RoutedEventHandler(this.button_SelectCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_CreateANewCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\W03_Customer_Selection.xaml"
            this.button_CreateANewCustomer.Click += new System.Windows.RoutedEventHandler(this.button_CreateANewCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_Close = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\W03_Customer_Selection.xaml"
            this.button_Close.Click += new System.Windows.RoutedEventHandler(this.button_Close_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.checkbox_SearchByDate = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.label_Count = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.checkbox_SearchByFirstLetter = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

