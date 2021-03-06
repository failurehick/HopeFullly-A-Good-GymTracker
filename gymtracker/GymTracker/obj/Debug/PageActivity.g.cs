﻿#pragma checksum "..\..\PageActivity.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E8D495463FDEEB4D927F689AFF6ED93B2C81CAE74F872C166F1305C9492DBD77"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GymTracker;
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


namespace GymTracker {
    
    
    /// <summary>
    /// PageActivity
    /// </summary>
    public partial class PageActivity : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\PageActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MachinesCombo;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\PageActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InclinedCheckBoxLabel;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\PageActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox InclinedCheckBox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\PageActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LevelsCombo;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\PageActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DurationTextBox;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\PageActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddActivityButton;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\PageActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountOfActivitesTextBlock;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\PageActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ActivityListTextBlock;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\PageActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\PageActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PageSummaryButton;
        
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
            System.Uri resourceLocater = new System.Uri("/GymTracker;component/pageactivity.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageActivity.xaml"
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
            this.MachinesCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\PageActivity.xaml"
            this.MachinesCombo.Loaded += new System.Windows.RoutedEventHandler(this.MachinesCombo_Loaded);
            
            #line default
            #line hidden
            
            #line 48 "..\..\PageActivity.xaml"
            this.MachinesCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MachinesCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.InclinedCheckBoxLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.InclinedCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.LevelsCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 68 "..\..\PageActivity.xaml"
            this.LevelsCombo.Loaded += new System.Windows.RoutedEventHandler(this.LevelsCombo_Loaded);
            
            #line default
            #line hidden
            
            #line 68 "..\..\PageActivity.xaml"
            this.LevelsCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LevelsCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DurationTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AddActivityButton = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\PageActivity.xaml"
            this.AddActivityButton.Click += new System.Windows.RoutedEventHandler(this.AddActivityButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CountOfActivitesTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ActivityListTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\PageActivity.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.PageSummaryButton = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\PageActivity.xaml"
            this.PageSummaryButton.Click += new System.Windows.RoutedEventHandler(this.PageSummaryButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

