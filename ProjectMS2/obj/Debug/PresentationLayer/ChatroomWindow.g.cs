﻿#pragma checksum "..\..\..\PresentationLayer\ChatroomWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544F408BEA45A9BB19C87E4E4A14729207262575"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjectMS2.BusinessLayer;
using ProjectMS2.PresentationLayer;
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


namespace ProjectMS2.PresentationLayer {
    
    
    /// <summary>
    /// ChatroomWindow
    /// </summary>
    public partial class ChatroomWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 31 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Logout;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_sendMsg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lst_Display;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_send;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_IdFilter;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_uNameFilter;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_gId;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_uName;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterbtn;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Con;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chk_as;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chk_des;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chk_time;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chk_nickname;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chk_gId;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectMS2;component/presentationlayer/chatroomwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
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
            
            #line 11 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            ((ProjectMS2.PresentationLayer.ChatroomWindow)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Window_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Logout = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            this.Logout.Click += new System.Windows.RoutedEventHandler(this.click_btn_logout);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtBox_sendMsg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.lst_Display = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.btn_send = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            this.btn_send.Click += new System.Windows.RoutedEventHandler(this.Button_Send_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtBox_IdFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            this.txtBox_IdFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBox_IdFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtBox_uNameFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            this.txtBox_uNameFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBox_uNameFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lbl_gId = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lbl_uName = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.filterbtn = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            this.filterbtn.Click += new System.Windows.RoutedEventHandler(this.filterbtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lbl_Con = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.chk_as = ((System.Windows.Controls.RadioButton)(target));
            
            #line 59 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            this.chk_as.Checked += new System.Windows.RoutedEventHandler(this.chk_as_Checked);
            
            #line default
            #line hidden
            return;
            case 14:
            this.chk_des = ((System.Windows.Controls.RadioButton)(target));
            
            #line 60 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            this.chk_des.Checked += new System.Windows.RoutedEventHandler(this.chk_des_Checked);
            
            #line default
            #line hidden
            return;
            case 15:
            this.chk_time = ((System.Windows.Controls.RadioButton)(target));
            
            #line 65 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            this.chk_time.Checked += new System.Windows.RoutedEventHandler(this.chk_time_Checked);
            
            #line default
            #line hidden
            return;
            case 16:
            this.chk_nickname = ((System.Windows.Controls.RadioButton)(target));
            
            #line 66 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            this.chk_nickname.Checked += new System.Windows.RoutedEventHandler(this.chk_nickname_Checked);
            
            #line default
            #line hidden
            return;
            case 17:
            this.chk_gId = ((System.Windows.Controls.RadioButton)(target));
            
            #line 67 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            this.chk_gId.Checked += new System.Windows.RoutedEventHandler(this.chk_gId_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 5:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 43 "..\..\..\PresentationLayer\ChatroomWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ListViewItem_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

