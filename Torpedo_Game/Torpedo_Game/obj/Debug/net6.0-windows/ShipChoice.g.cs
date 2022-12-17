﻿#pragma checksum "..\..\..\ShipChoice.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05F4E6D769ED4228783E98FABBF27DE8BAE57CEA"
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
    /// ShipChoice
    /// </summary>
    public partial class ShipChoice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label welcomeLabel;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button carrierBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button battleshipBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cruiserBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submarineBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button destroyerBtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Rotate;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RandomBtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetBtn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitBtn;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\ShipChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid playfield;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Torpedo_Game;component/shipchoice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ShipChoice.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.welcomeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.carrierBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\ShipChoice.xaml"
            this.carrierBtn.Click += new System.Windows.RoutedEventHandler(this.shipBtn);
            
            #line default
            #line hidden
            return;
            case 3:
            this.battleshipBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\ShipChoice.xaml"
            this.battleshipBtn.Click += new System.Windows.RoutedEventHandler(this.shipBtn);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cruiserBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\ShipChoice.xaml"
            this.cruiserBtn.Click += new System.Windows.RoutedEventHandler(this.shipBtn);
            
            #line default
            #line hidden
            return;
            case 5:
            this.submarineBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\ShipChoice.xaml"
            this.submarineBtn.Click += new System.Windows.RoutedEventHandler(this.shipBtn);
            
            #line default
            #line hidden
            return;
            case 6:
            this.destroyerBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\ShipChoice.xaml"
            this.destroyerBtn.Click += new System.Windows.RoutedEventHandler(this.shipBtn);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Rotate = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\ShipChoice.xaml"
            this.Rotate.Click += new System.Windows.RoutedEventHandler(this.rotateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RandomBtn = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\ShipChoice.xaml"
            this.RandomBtn.Click += new System.Windows.RoutedEventHandler(this.randomBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ResetBtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\ShipChoice.xaml"
            this.ResetBtn.Click += new System.Windows.RoutedEventHandler(this.resetBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SubmitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\ShipChoice.xaml"
            this.SubmitBtn.Click += new System.Windows.RoutedEventHandler(this.submitBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.playfield = ((System.Windows.Controls.Grid)(target));
            
            #line 62 "..\..\..\ShipChoice.xaml"
            this.playfield.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.onGridMouseOver);
            
            #line default
            #line hidden
            
            #line 62 "..\..\..\ShipChoice.xaml"
            this.playfield.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.onGridMouseClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

