﻿#pragma checksum "..\..\..\SubViews\MusicView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "92787147C0701BB49BB9E8A4305CE4B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34011
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using CloudX;
using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace CloudX.SubViews {
    
    
    /// <summary>
    /// MusicView
    /// </summary>
    public partial class MusicView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\SubViews\MusicView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MusicList;
        
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
            System.Uri resourceLocater = new System.Uri("/CloudX;component/subviews/musicview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SubViews\MusicView.xaml"
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
            this.MusicList = ((System.Windows.Controls.ListView)(target));
            
            #line 30 "..\..\..\SubViews\MusicView.xaml"
            this.MusicList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.MusicList_OnMouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\SubViews\MusicView.xaml"
            this.MusicList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged_1);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\SubViews\MusicView.xaml"
            this.MusicList.DragEnter += new System.Windows.DragEventHandler(this.ListView_DragEnter_1);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\SubViews\MusicView.xaml"
            this.MusicList.Drop += new System.Windows.DragEventHandler(this.MusicList_OnDrop);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\SubViews\MusicView.xaml"
            this.MusicList.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MusicList_OnMouseRightButtonDown);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\SubViews\MusicView.xaml"
            this.MusicList.MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.MusicList_OnMouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
