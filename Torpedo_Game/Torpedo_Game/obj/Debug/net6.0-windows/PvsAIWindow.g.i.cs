﻿#pragma checksum "..\..\..\PvsAIWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DDF5391EE124158791AA55E3B975BAFC118AEE23"
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
using Torpedo_Game;


namespace Torpedo_Game {
    
    
    /// <summary>
    /// PvsAIWindow
    /// </summary>
    public partial class PvsAIWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\PvsAIWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Torpedo_Game.PvsAIWindow pvsaiWindow;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\PvsAIWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PlayerName;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\PvsAIWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\PvsAIWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Torpedo_Game;component/pvsaiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PvsAIWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pvsaiWindow = ((Torpedo_Game.PvsAIWindow)(target));
            return;
            case 2:
            this.PlayerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.playButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\PvsAIWindow.xaml"
            this.playButton.Click += new System.Windows.RoutedEventHandler(this.playButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\PvsAIWindow.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

