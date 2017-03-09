﻿// <auto-generated />
namespace DesigntimeSourcecodeGenerator.Test.View
{
	using System;
	using System.Windows;
	using System.Windows.Controls;
	using System.ComponentModel;

	/// <summary>
	/// このクラスはMainWindowViewクラスの定義によって、自動生成されました。
	/// このファイルをエディタで直接編集しないでください。
	/// </summary>
	public partial class MainWindowView
	{
#region 住所
		/// <summary>
		/// 住所
		/// </summary>
		public static readonly DependencyProperty AddressProperty = DependencyProperty.Register("Address", typeof(string), typeof(MainWindowView));
		public string Address
		{
			get { return (string)this.GetValue(AddressProperty); }
			set { this.SetValue(AddressProperty, value); }
		}
#endregion
#region 数
		/// <summary>
		/// 数
		/// </summary>
		public static readonly DependencyProperty CountProperty = DependencyProperty.Register("Count", typeof(int), typeof(MainWindowView), new UIPropertyMetadata(0, OnCount));
		public int Count
		{
			get { return (int)this.GetValue(CountProperty); }
			 set { this.SetValue(CountProperty, value); }
		}
		//private static void OnCount(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
		//{
		//}
#endregion
#region 選択
		/// <summary>
		/// 選択
		/// </summary>
		public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.Register("IsSelected", typeof(bool), typeof(MainWindowView), new UIPropertyMetadata(false, OnIsSelected));
		public bool IsSelected
		{
			get { return (bool)this.GetValue(IsSelectedProperty); }
			 set { this.SetValue(IsSelectedProperty, value); }
		}
		private static void OnIsSelected(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
		{
			var o = (MainWindowView)depObj;

			if(o != null)
			{
				o.SetIsSelected((bool)e.NewValue);
			}
		}
		//private void SetIsSelected(bool value) {}
#endregion
#region 開き
		/// <summary>
		/// 開き
		/// </summary>
		public static readonly DependencyProperty IsOpenedProperty = DependencyProperty.Register("IsOpened", typeof(bool), typeof(MainWindowView), new FrameworkPropertyMetadata((bool)false, FrameworkPropertyMetadataOptions.None, new PropertyChangedCallback(OnIsOpenedChanged)));
		public bool IsOpened
		{
			get { return (bool)this.GetValue(IsOpenedProperty); }
			set { this.SetValue(IsOpenedProperty, value); }
		}
		//private static void OnIsOpenedChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
		//{
		//	MainWindowView ctrl = (MainWindowView)depObj;
		//}
#endregion
#region アクティブ
		/// <summary>
		/// アクティブ
		/// </summary>
		public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(MainWindowView), new FrameworkPropertyMetadata((bool)false, FrameworkPropertyMetadataOptions.Inherits | FrameworkPropertyMetadataOptions.AffectsMeasure, new PropertyChangedCallback(OnIsActiveChanged)));
		public bool IsActive
		{
			get { return (bool)this.GetValue(IsActiveProperty); }
			set { this.SetValue(IsActiveProperty, value); }
		}
		//private static void OnIsActiveChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
		//{
		//	MainWindowView ctrl = (MainWindowView)depObj;
		//}
#endregion
#region アイテムマウスオーバー
		/// <summary>
		/// アイテムマウスオーバー
		/// </summary>
		public static RoutedEvent ItemMouseOverEvent = EventManager.RegisterRoutedEvent("ItemMouseOver", RoutingStrategy.Tunnel, typeof(ItemMouseOverEventHandler), typeof(MainWindowView));
		public event ItemMouseOverEventHandler ItemMouseOver
		{
			add { this.AddHandler(ItemMouseOverEvent, value); }
			remove { this.RemoveHandler(ItemMouseOverEvent, value); }
		}
		public delegate void ItemMouseOverEventHandler(object sender, ItemMouseOverEventArgs e);
		//public class ItemMouseOverEventArgs : RoutedEventArgs
		//{
		//	public ItemMouseOverEventArgs(RoutedEvent routedEvent) : base(routedEvent) {}
		//}
#endregion
	}
}
