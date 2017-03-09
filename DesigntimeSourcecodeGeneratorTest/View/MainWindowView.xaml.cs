using Designtime.Sourcecode.Generator.Attributes;
using DesigntimeSourcecodeGenerator.Test.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesigntimeSourcecodeGenerator.Test.View
{
    public class ItemMouseOverEventArgs : RoutedEventArgs
    {
        public ItemMouseOverEventArgs(RoutedEvent routedEvent) : base(routedEvent) { }
    }

    /// <summary>
    /// MainWindowView.xaml の相互作用ロジック
    /// </summary>
    // 依存プロパティの生成
    [TemplateGenerateAnnotation(Name = "Address", Type = typeof(string), Kind = "DependencyProperty", Comment = "住所")]
    // 依存関係プロパティの生成
    [TemplateGenerateAnnotation(Name = "Count", Type = typeof(int), Kind = "UIPropertyMetadata", Comment = "数", DefaultValue = "0")]
    // 依存関係プロパティの生成(Callback関数の生成)
    [TemplateGenerateAnnotation(Name = "IsSelected", Type = typeof(bool), Kind = "UIPropertyMetadata", DefaultValue = "false", Comment = "選択", PropertyChangedCallback = true)]
    /// 依存関係プロパティの生成
    [TemplateGenerateAnnotation(Name = "IsOpened", Type = typeof(bool), Kind = "PropertyChangedCallback", Comment = "開き", DefaultValue = "false")]
    /// 依存関係プロパティの生成
    [TemplateGenerateAnnotation(Name = "IsActive", Type = typeof(bool), Kind = "PropertyChangedCallback", Comment = "アクティブ", DefaultValue = "false", MetadataOptions = "FrameworkPropertyMetadataOptions.Inherits | FrameworkPropertyMetadataOptions.AffectsMeasure")]
    // ルーティングイベントの生成
    [TemplateGenerateAnnotation(Name = "ItemMouseOver", Kind = "RoutedEvent", RoutingStrategy = "RoutingStrategy.Tunnel", Comment = "アイテムマウスオーバー")]
    public partial class MainWindowView : UserControl
    {
        public MainWindowView()
        {
            InitializeComponent();

            this.DataContext = new MainWindowViewModel();

            this.Address = "Tokyo";
        }

        /// <summary>
        /// 依存関係プロパティの生成
        /// </summary>
        /// <param name="depObj"></param>
        /// <param name="e"></param>
        private static void OnCount(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
        }

        /// <summary>
        /// 依存関係プロパティの生成(Callback関数の生成)
        /// </summary>
        /// <param name="value"></param>
        private void SetIsSelected(bool value)
        {
        }

        /// <summary>
        /// 依存関係プロパティの生成
        /// </summary>
        /// <param name="depObj"></param>
        /// <param name="e"></param>
        private static void OnIsOpenedChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
        }

        /// <summary>
        /// 依存関係プロパティの生成
        /// </summary>
        /// <param name="depObj"></param>
        /// <param name="e"></param>
        private static void OnIsActiveChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            MainWindowView ctrl = (MainWindowView)depObj;
        }
    }
}
