// Updated by XamlIntelliSenseFileGenerator 27/04/2022 12:42:11
#pragma checksum "..\..\LogIn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6DDD7EF56F77028C706E7F7A5EBAA1693F7522B8C78301A57511ABA933737E7A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Avaliacao1Lab3.Login.Logout;
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


namespace Avaliacao1Lab3.Login.Logout
{


    /// <summary>
    /// LogIn
    /// </summary>
    public partial class LogIn : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LOGIN;

#line default
#line hidden


#line 11 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Username;

#line default
#line hidden


#line 12 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Password;

#line default
#line hidden


#line 13 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserInput;

#line default
#line hidden


#line 15 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Avaliacao1Lab3;component/login.xaml", System.UriKind.Relative);

#line 1 "..\..\LogIn.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.LOGIN = ((System.Windows.Controls.Label)(target));
                    return;
                case 2:
                    this.Username = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.Password = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.UserInput = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.LoginButton = ((System.Windows.Controls.Button)(target));

#line 15 "..\..\LogIn.xaml"
                    this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}
