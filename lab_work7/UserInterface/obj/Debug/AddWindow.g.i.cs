﻿#pragma checksum "..\..\AddWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EA79EC340153A21E1CE5D282C164B267D7B4A1F88BDF55F638B306C5FCD16126"
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
using UserInterface;


namespace UserInterface {
    
    
    /// <summary>
    /// AddWindow
    /// </summary>
    public partial class AddWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UserInterface.AddWindow addWindow;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox floorBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button setFlatButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label flatTypeLabel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label flatTypeLabel_Copy;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label washerLabel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sroveTypeLabel;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox washerBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox stoveTypeBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
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
            System.Uri resourceLocater = new System.Uri("/UserInterface;component/addwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddWindow.xaml"
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
            this.addWindow = ((UserInterface.AddWindow)(target));
            
            #line 8 "..\..\AddWindow.xaml"
            this.addWindow.Closed += new System.EventHandler(this.showMain_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.typeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.floorBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\AddWindow.xaml"
            this.floorBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.floorBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.setFlatButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\AddWindow.xaml"
            this.setFlatButton.Click += new System.Windows.RoutedEventHandler(this.sendFlatButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.flatTypeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.flatTypeLabel_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.washerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.sroveTypeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.washerBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.stoveTypeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\AddWindow.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

