﻿#pragma checksum "G:\wp\MHXY\MHXY\UI\Character\EmpiricalRight.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2D7553B044B4CBBAB74BF8830CB6F25"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18449
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace MHXY.UI.Character {
    
    
    public partial class EmpiricalRight : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.PhoneTextBox textBox_start_grade;
        
        internal Microsoft.Phone.Controls.PhoneTextBox textBox_end_grade;
        
        internal System.Windows.Controls.TextBox textbox_requires_experience;
        
        internal System.Windows.Controls.Button button_calculate;
        
        internal System.Windows.Controls.Button button_empty;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/MHXY;component/UI/Character/EmpiricalRight.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.textBox_start_grade = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("textBox_start_grade")));
            this.textBox_end_grade = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("textBox_end_grade")));
            this.textbox_requires_experience = ((System.Windows.Controls.TextBox)(this.FindName("textbox_requires_experience")));
            this.button_calculate = ((System.Windows.Controls.Button)(this.FindName("button_calculate")));
            this.button_empty = ((System.Windows.Controls.Button)(this.FindName("button_empty")));
        }
    }
}

