﻿#pragma checksum "..\..\..\..\Pages\Categories\AjoutCategorie.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E459A9546F33E6E4F8B59FF689A924C3DC495BC80EBF3AE572705502472DBAFF"
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
    /// AjoutCategorie
    /// </summary>
    public partial class AjoutCategorie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\Pages\Categories\AjoutCategorie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPFModernVerticalMenu.Pages.Categories.AjoutCategorie Ajout_Categorie;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Pages\Categories\AjoutCategorie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CodeCategorie;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Pages\Categories\AjoutCategorie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox libelleCategorie;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Pages\Categories\AjoutCategorie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AjouterCategorie;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFModernVerticalMenu;component/pages/categories/ajoutcategorie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Categories\AjoutCategorie.xaml"
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
            this.Ajout_Categorie = ((WPFModernVerticalMenu.Pages.Categories.AjoutCategorie)(target));
            return;
            case 2:
            this.CodeCategorie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.libelleCategorie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AjouterCategorie = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Pages\Categories\AjoutCategorie.xaml"
            this.AjouterCategorie.Click += new System.Windows.RoutedEventHandler(this.btn_AjouterCategorie);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

