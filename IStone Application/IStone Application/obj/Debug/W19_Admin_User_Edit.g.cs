﻿#pragma checksum "..\..\W19_Admin_User_Edit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FA6AFB349B17AED10463A06E5887ADCAE3796AA99B92E396F76B7A010A04A9E5"
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
    /// W19_Admin_User_Edit
    /// </summary>
    public partial class W19_Admin_User_Edit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\W19_Admin_User_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_Search;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\W19_Admin_User_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Search;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\W19_Admin_User_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid_Users;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\W19_Admin_User_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Count;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\W19_Admin_User_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_DeleteUser;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\W19_Admin_User_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_SetAdmin;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\W19_Admin_User_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_SetWorker;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\W19_Admin_User_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Back;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\W19_Admin_User_Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ApplyChanges;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\W19_Admin_User_Edit.xaml"
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
            System.Uri resourceLocater = new System.Uri("/IStone Application;component/w19_admin_user_edit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\W19_Admin_User_Edit.xaml"
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
            
            #line 11 "..\..\W19_Admin_User_Edit.xaml"
            this.button_Search.Click += new System.Windows.RoutedEventHandler(this.button_Search_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.datagrid_Users = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\W19_Admin_User_Edit.xaml"
            this.datagrid_Users.BeginningEdit += new System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>(this.datagrid_Users_BeginningEdit);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label_Count = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.button_DeleteUser = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\W19_Admin_User_Edit.xaml"
            this.button_DeleteUser.Click += new System.Windows.RoutedEventHandler(this.button_DeleteUser_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_SetAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\W19_Admin_User_Edit.xaml"
            this.button_SetAdmin.Click += new System.Windows.RoutedEventHandler(this.button_SetAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button_SetWorker = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\W19_Admin_User_Edit.xaml"
            this.button_SetWorker.Click += new System.Windows.RoutedEventHandler(this.button_SetWorker_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button_Back = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\W19_Admin_User_Edit.xaml"
            this.button_Back.Click += new System.Windows.RoutedEventHandler(this.button_Back_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.button_ApplyChanges = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\W19_Admin_User_Edit.xaml"
            this.button_ApplyChanges.Click += new System.Windows.RoutedEventHandler(this.button_ApplyChanges_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.checkbox_SearchByFirstLetter = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

