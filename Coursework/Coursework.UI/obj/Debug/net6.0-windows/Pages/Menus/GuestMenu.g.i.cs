﻿#pragma checksum "..\..\..\..\..\Pages\Menus\GuestMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C85012BF9A7363F1AD988935892816291521F83A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Coursework.UI.Pages.Menus;
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


namespace Coursework.UI.Pages.Menus {
    
    
    /// <summary>
    /// GuestMenu
    /// </summary>
    public partial class GuestMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Coursework.UI;component/pages/menus/guestmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\Menus\GuestMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\..\..\Pages\Menus\GuestMenu.xaml"
            ((System.Windows.Controls.Border)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseEnter);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\..\..\Pages\Menus\GuestMenu.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\..\..\..\Pages\Menus\GuestMenu.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\..\..\..\Pages\Menus\GuestMenu.xaml"
            ((System.Windows.Controls.Border)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseEnter);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\..\..\Pages\Menus\GuestMenu.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 21 "..\..\..\..\..\Pages\Menus\GuestMenu.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_Docs);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

