﻿#pragma checksum "..\..\..\Views\RegistrationView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62A59B3A9E52CFAC4F09A07EF82CCB33F28C0075"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Rentals.Views;
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


namespace Rentals.Views {
    
    
    /// <summary>
    /// RegistrationView
    /// </summary>
    public partial class RegistrationView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock registration;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox username;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mobileTel;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox eMail;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox password;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstName;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button regButton;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Rentals;component/views/registrationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\RegistrationView.xaml"
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
            this.registration = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.username = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\..\Views\RegistrationView.xaml"
            this.username.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.RegLogBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\Views\RegistrationView.xaml"
            this.username.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.RegLogBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mobileTel = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\..\Views\RegistrationView.xaml"
            this.mobileTel.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TelBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 68 "..\..\..\Views\RegistrationView.xaml"
            this.mobileTel.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TelBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.eMail = ((System.Windows.Controls.TextBox)(target));
            
            #line 79 "..\..\..\Views\RegistrationView.xaml"
            this.eMail.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.EMailBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 80 "..\..\..\Views\RegistrationView.xaml"
            this.eMail.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.EMailBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.password = ((System.Windows.Controls.TextBox)(target));
            
            #line 91 "..\..\..\Views\RegistrationView.xaml"
            this.password.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.Password_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 92 "..\..\..\Views\RegistrationView.xaml"
            this.password.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.Password_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.firstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 104 "..\..\..\Views\RegistrationView.xaml"
            this.firstName.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.FirstNameBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\Views\RegistrationView.xaml"
            this.firstName.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.FirstNameBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.regButton = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\Views\RegistrationView.xaml"
            this.regButton.Click += new System.Windows.RoutedEventHandler(this.confirmButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\..\Views\RegistrationView.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

