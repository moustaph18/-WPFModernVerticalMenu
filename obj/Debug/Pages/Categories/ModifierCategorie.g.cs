﻿#pragma checksum "..\..\..\..\Pages\Categories\ModifierCategorie.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "494310D3F30C9B4B7001E3F15147E02A4E5373FE15872E0571CB44A4AD7E0048"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WPFModernVerticalMenu.Pages.Categories;


namespace WPFModernVerticalMenu.Pages.Categories {
    
    
    /// <summary>
    /// ModifierCategorie
    /// </summary>
    public partial class ModifierCategorie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Pages\Categories\ModifierCategorie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CodeCategorie;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Pages\Categories\ModifierCategorie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox libelleCategorie;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Pages\Categories\ModifierCategorie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModifierCategorie;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFModernVerticalMenu;component/pages/categories/modifiercategorie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Categories\ModifierCategorie.xaml"
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
            this.CodeCategorie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.libelleCategorie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnModifierCategorie = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Pages\Categories\ModifierCategorie.xaml"
            this.btnModifierCategorie.Click += new System.Windows.RoutedEventHandler(this.btnModifier);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

