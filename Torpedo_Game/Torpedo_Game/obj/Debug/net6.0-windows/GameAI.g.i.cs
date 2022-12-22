﻿#pragma checksum "..\..\..\GameAI.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F18E20B7D7C5D6F6D8BCF3C655659E9B36F0CADB"
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
    /// GameAI
    /// </summary>
    public partial class GameAI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label roundsLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label playerHitsLabel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label computerHitsLabel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button surrrendBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tableLabel;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid leftTable;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid rightTable;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid carrierHpGrid;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid battleshipHpGrid;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid cruiserHpGrid;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid submarineHpGrid;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\GameAI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid destroyerHpGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Torpedo_Game;component/gameai.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GameAI.xaml"
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
            this.roundsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.playerHitsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.computerHitsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.surrrendBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\GameAI.xaml"
            this.surrrendBtn.Click += new System.Windows.RoutedEventHandler(this.surrendBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 34 "..\..\..\GameAI.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.stats_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tableLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.leftTable = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.rightTable = ((System.Windows.Controls.Grid)(target));
            
            #line 90 "..\..\..\GameAI.xaml"
            this.rightTable.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.onGridMouseOver);
            
            #line default
            #line hidden
            
            #line 90 "..\..\..\GameAI.xaml"
            this.rightTable.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.onGridMouseClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.carrierHpGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.battleshipHpGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.cruiserHpGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 12:
            this.submarineHpGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            this.destroyerHpGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

