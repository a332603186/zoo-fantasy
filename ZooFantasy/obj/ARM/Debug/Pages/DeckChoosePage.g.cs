﻿#pragma checksum "E:\编程\Projects\实验工程\ZooFantasy\ZooFantasy\Pages\DeckChoosePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "02C15E15D8AD41B1AA47CABF522DF913"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZooFantasy.Pages
{
    partial class DeckChoosePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.CardDetailRelativePanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 2:
                {
                    this.DeckGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 3:
                {
                    this.ChooseDeckTip = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.ContinueButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 47 "..\..\..\Pages\DeckChoosePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ContinueButton).Click += this.ContinueButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.CardsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 49 "..\..\..\Pages\DeckChoosePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CardsButton).Click += this.CardsButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.DetailMinionCardImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.DetailMinionCardName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.DetailMinionCardCost = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.DetailMinionCardAttack = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.DetailMinionCardHealth = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.CancelDetailButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\Pages\DeckChoosePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CancelDetailButton).Click += this.CancelDetailButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
