﻿#pragma checksum "..\..\signin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "075D9A02FEE80EC00B6597784D114C76BCD5BE7A88A261DF0C8DD90A7E6BF9CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using facebook;


namespace facebook {
    
    
    /// <summary>
    /// signin
    /// </summary>
    public partial class signin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox user_t;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox password_t;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sign_in;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sign_up;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forget_pass;
        
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
            System.Uri resourceLocater = new System.Uri("/facebook;component/signin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\signin.xaml"
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
            this.user_t = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.password_t = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.sign_in = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\signin.xaml"
            this.sign_in.Click += new System.Windows.RoutedEventHandler(this.sign_in_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sign_up = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\signin.xaml"
            this.sign_up.Click += new System.Windows.RoutedEventHandler(this.sign_up_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.forget_pass = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\signin.xaml"
            this.forget_pass.Click += new System.Windows.RoutedEventHandler(this.forget_pass_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 28 "..\..\signin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

