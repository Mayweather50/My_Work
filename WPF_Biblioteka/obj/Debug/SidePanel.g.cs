﻿#pragma checksum "..\..\SidePanel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A2BD82A59AAA1F7BD4C2898AEF5BD66C03AD3DFC730F0657F5A1611C63CB33A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WPF_Biblioteka;


namespace WPF_Biblioteka {
    
    
    /// <summary>
    /// SidePanel
    /// </summary>
    public partial class SidePanel : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 253 "..\..\SidePanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SidePanel_ListBox;
        
        #line default
        #line hidden
        
        
        #line 525 "..\..\SidePanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem dashboard_sidepanel_listboxitem;
        
        #line default
        #line hidden
        
        
        #line 529 "..\..\SidePanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem mail_sidepanel_listboxitem;
        
        #line default
        #line hidden
        
        
        #line 535 "..\..\SidePanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem customer_sidepanel_listboxitem;
        
        #line default
        #line hidden
        
        
        #line 539 "..\..\SidePanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem analytics_sidepanel_listboxitem;
        
        #line default
        #line hidden
        
        
        #line 543 "..\..\SidePanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem settings_sidepanel_listboxitem;
        
        #line default
        #line hidden
        
        
        #line 561 "..\..\SidePanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image mail_submenu_indicator;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_Biblioteka;component/sidepanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SidePanel.xaml"
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
            this.SidePanel_ListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.dashboard_sidepanel_listboxitem = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 3:
            this.mail_sidepanel_listboxitem = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 532 "..\..\SidePanel.xaml"
            this.mail_sidepanel_listboxitem.Selected += new System.Windows.RoutedEventHandler(this.mail_sidepanel_listboxitem_Selected);
            
            #line default
            #line hidden
            
            #line 533 "..\..\SidePanel.xaml"
            this.mail_sidepanel_listboxitem.Unselected += new System.Windows.RoutedEventHandler(this.mail_sidepanel_listboxitem_Unselected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.customer_sidepanel_listboxitem = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 5:
            this.analytics_sidepanel_listboxitem = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 6:
            this.settings_sidepanel_listboxitem = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 545 "..\..\SidePanel.xaml"
            this.settings_sidepanel_listboxitem.Selected += new System.Windows.RoutedEventHandler(this.settings_sidepanel_listboxitem_Selected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mail_submenu_indicator = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

