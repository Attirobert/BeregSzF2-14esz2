﻿#pragma checksum "..\..\..\..\UserControls\PasswordBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A87A5888C0515B032348328B3FDB874B3DF2F590"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SZBkiseloadas.Icons;
using SZBkiseloadas.UserControls;
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


namespace SZBkiseloadas.UserControls {
    
    
    /// <summary>
    /// PasswordBox
    /// </summary>
    public partial class PasswordBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\UserControls\PasswordBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SZBkiseloadas.UserControls.PasswordBox input;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\UserControls\PasswordBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl contentControl1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\UserControls\PasswordBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox textBox1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\UserControls\PasswordBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label contentControl2;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\UserControls\PasswordBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid eye;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\UserControls\PasswordBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SZBkiseloadas.Icons.EyeOpen eyeOpen;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\UserControls\PasswordBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SZBkiseloadas.Icons.EyeClose eyeClose;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SZBkiseloadas;component/usercontrols/passwordbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\PasswordBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.input = ((SZBkiseloadas.UserControls.PasswordBox)(target));
            return;
            case 2:
            this.contentControl1 = ((System.Windows.Controls.ContentControl)(target));
            
            #line 11 "..\..\..\..\UserControls\PasswordBox.xaml"
            this.contentControl1.GotFocus += new System.Windows.RoutedEventHandler(this.contentControl1_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBox1 = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 12 "..\..\..\..\UserControls\PasswordBox.xaml"
            this.textBox1.PasswordChanged += new System.Windows.RoutedEventHandler(this.Password_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.contentControl2 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.eye = ((System.Windows.Controls.Grid)(target));
            
            #line 14 "..\..\..\..\UserControls\PasswordBox.xaml"
            this.eye.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.eye_PreviewMouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.eyeOpen = ((SZBkiseloadas.Icons.EyeOpen)(target));
            return;
            case 7:
            this.eyeClose = ((SZBkiseloadas.Icons.EyeClose)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

