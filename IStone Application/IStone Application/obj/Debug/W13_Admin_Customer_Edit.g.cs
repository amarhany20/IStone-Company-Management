﻿#pragma checksum "..\..\W13_Admin_Customer_Edit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D6AB978EA67E26C44AF763A5B806B6C8E9DDB8B4FD11D90F2C587D9F06E044F3"
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
    /// W13_Admin_Customer_Edit
    /// </summary>
    public partial class W13_Admin_Customer_Edit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_Search;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Search;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid_Customers;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Count;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_SearchByDate;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ApplyChanges;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_DeleteCustomer;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_SelectUser;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Back;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_SearchByFirstLetter;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\W13_Admin_Customer_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CreateCustomer;
        
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
            System.Uri resourceLocater = new System.Uri("/IStone Application;component/w13_admin_customer_edit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\W13_Admin_Customer_Edit.xaml"
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
            
            #line 12 "..\..\W13_Admin_Customer_Edit.xaml"
            this.button_Search.Click += new System.Windows.RoutedEventHandler(this.button_Search_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.datagrid_Customers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\W13_Admin_Customer_Edit.xaml"
            this.datagrid_Customers.BeginningEdit += new System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>(this.datagrid_Customers_BeginningEdit);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label_Count = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.checkbox_SearchByDate = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.button_ApplyChanges = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\W13_Admin_Customer_Edit.xaml"
            this.button_ApplyChanges.Click += new System.Windows.RoutedEventHandler(this.button_ApplyChanges_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button_DeleteCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\W13_Admin_Customer_Edit.xaml"
            this.button_DeleteCustomer.Click += new System.Windows.RoutedEventHandler(this.button_DeleteCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button_SelectUser = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\W13_Admin_Customer_Edit.xaml"
            this.button_SelectUser.Click += new System.Windows.RoutedEventHandler(this.button_SelectUser_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.button_Back = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\W13_Admin_Customer_Edit.xaml"
            this.button_Back.Click += new System.Windows.RoutedEventHandler(this.button_Back_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.checkbox_SearchByFirstLetter = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.button_CreateCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\W13_Admin_Customer_Edit.xaml"
            this.button_CreateCustomer.Click += new System.Windows.RoutedEventHandler(this.button_CreateCustomer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
