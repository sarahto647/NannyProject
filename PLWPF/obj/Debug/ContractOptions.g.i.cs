﻿#pragma checksum "..\..\ContractOptions.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E69B69427ACA5E8BA1E9B8CD63D1AC2B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using PLWPF;
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


namespace PLWPF {
    
    
    /// <summary>
    /// ContractOptions
    /// </summary>
    public partial class ContractOptions : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\ContractOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddContract;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ContractOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveContract;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ContractOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateContract;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ContractOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OthersContract;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/contractoptions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ContractOptions.xaml"
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
            this.AddContract = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\ContractOptions.xaml"
            this.AddContract.Click += new System.Windows.RoutedEventHandler(this.AddContract_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RemoveContract = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\ContractOptions.xaml"
            this.RemoveContract.Click += new System.Windows.RoutedEventHandler(this.RemoveContract_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UpdateContract = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\ContractOptions.xaml"
            this.UpdateContract.Click += new System.Windows.RoutedEventHandler(this.UpdateContract_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OthersContract = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ContractOptions.xaml"
            this.OthersContract.Click += new System.Windows.RoutedEventHandler(this.OthersContract_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

