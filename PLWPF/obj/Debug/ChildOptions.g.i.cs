﻿#pragma checksum "..\..\ChildOptions.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A40FD8A7B29C0C6262C6C77B3877D02B"
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
    /// ChildOptions
    /// </summary>
    public partial class ChildOptions : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\ChildOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddChild;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ChildOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveChild;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ChildOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateChild;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ChildOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OthersChild;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/childoptions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChildOptions.xaml"
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
            this.AddChild = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\ChildOptions.xaml"
            this.AddChild.Click += new System.Windows.RoutedEventHandler(this.AddChild_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RemoveChild = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\ChildOptions.xaml"
            this.RemoveChild.Click += new System.Windows.RoutedEventHandler(this.RemoveChild_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UpdateChild = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\ChildOptions.xaml"
            this.UpdateChild.Click += new System.Windows.RoutedEventHandler(this.UpdateChild_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OthersChild = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ChildOptions.xaml"
            this.OthersChild.Click += new System.Windows.RoutedEventHandler(this.OthersChild_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
