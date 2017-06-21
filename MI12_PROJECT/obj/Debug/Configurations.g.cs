﻿#pragma checksum "..\..\Configurations.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5F3CF7E109E537D6A78ADA385C8EAA9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Samples.Kinect.SkeletonBasics;
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


namespace Microsoft.Samples.Kinect.SkeletonBasics {
    
    
    /// <summary>
    /// Configurations
    /// </summary>
    public partial class Configurations : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Configurations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox activateSound;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Configurations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox activateColour;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Configurations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox activateGIF;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Configurations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElementSound;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Configurations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElementGIF;
        
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
            System.Uri resourceLocater = new System.Uri("/SkeletonBasics-WPF;component/configurations.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Configurations.xaml"
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
            this.activateSound = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.activateColour = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.activateGIF = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.mediaElementSound = ((System.Windows.Controls.MediaElement)(target));
            
            #line 28 "..\..\Configurations.xaml"
            this.mediaElementSound.MediaEnded += new System.Windows.RoutedEventHandler(this.mediaElementSound_Ended);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mediaElementGIF = ((System.Windows.Controls.MediaElement)(target));
            
            #line 29 "..\..\Configurations.xaml"
            this.mediaElementGIF.MediaEnded += new System.Windows.RoutedEventHandler(this.mediaElementGIF_Ended);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

