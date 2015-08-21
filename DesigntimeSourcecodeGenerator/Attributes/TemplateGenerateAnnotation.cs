
namespace Designtime.Sourcecode.Generator.Attributes
{
    using System;

    /// <summary>
    /// プロパティ、コマンドなどの生成をDesigntimeSourcecodeGeneratorへ属性で指示します。
    /// 複数指定することも可能です。
    /// クラスは、１ファイル１クラスにしてください。
    /// 生成元クラスは、必ずpartialにしてください。
    /// 例：単純プロパティの生成
    /// [TemplateGenerateAnnotation(Name = "Age", Type = typeof(int), Comment = "年齢")]
    /// 例：プロパティのsetterをprivateで生成
    /// [TemplateGenerateAnnotation(Name = "Age", Type = typeof(int), Comment = "年齢", SetterPrivate = true)]
    /// 例：値更新時に、PropertyChangedイベントを発火するように生成
    /// [TemplateGenerateAnnotation(Name = "Age", Type = typeof(int), Comment = "年齢", RaisePropertyChanged = true)]
    /// 例：値更新時に、AgeNotification()メソッドを呼び出すコードを生成
    /// [TemplateGenerateAnnotation(Name = "Age", Type = typeof(int), Comment = "年齢", RaisePropertyChanged = true, SetNotificator = true)]
    /// 例：依存プロパティの生成
    /// [TemplateGenerateAnnotation(Name = "Age", Type = typeof(int), Kind = "DependencyProperty", Comment = "年齢")]
    /// 例：依存関係プロパティの生成
    /// [TemplateGenerateAnnotation(Name = "Age", Type = typeof(int), Kind = "UIPropertyMetadata", Comment = "年齢", DefaultValue = "0")]
    /// 例：依存関係プロパティの生成(Callback関数の生成)
    /// [TemplateGenerateAnnotation(Name = "Age", Type = typeof(int), Kind = "UIPropertyMetadata", Comment = "年齢", DefaultValue = "0", PropertyChangedCallback = true)]
    /// 例：依存関係プロパティの生成
    /// [TemplateGenerateAnnotation(Name = "Age", Type = typeof(int), Kind = "PropertyChangedCallback", Comment = "年齢", DefaultValue = "0")]
    /// 例：コマンドの生成
    /// [TemplateGenerateAnnotation(Name = "Push", Kind = "Command", Comment = "押す")]
    /// 例：コマンドの生成（CanPushメソッドも生成）
    /// [TemplateGenerateAnnotation(Name = "Push", Kind = "Command", CanGenetate = true, Comment = "押す")]
    /// 例：コマンドの生成（CommandParameterを受け取れるメソッドを生成）
    /// [TemplateGenerateAnnotation(Name = "Push", Kind = "Command", Comment = "押す", CommandParameter = typeof(string))]
    /// 例：イベントの生成
    /// [TemplateGenerateAnnotation(Name = "SelectChanged", Kind = "Event", Comment = "選択変更")]
    /// 例：ルーティングイベントの生成
    /// [TemplateGenerateAnnotation(Name = "ItemMouseOver", Kind = "RoutedEvent", RoutingStrategy = "RoutingStrategy.Tunnel", Comment = "アイテムマウスオーバー")]
    /// 例：ロガークラスの生成
    /// [TemplateGenerateAnnotation(Kind = "Logger", Comment = "Logger")]
    /// 例：シングルトンの生成
    /// [TemplateGenerateAnnotation(Kind = "Singleton", Comment = "Singleton")]
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class TemplateGenerateAnnotation : Attribute
    {
        /// <summary>
        /// プロパティ名、コマンド名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// プロパティ型
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// 依存関係プロパティの初期値
        /// </summary>
        public object DefaultValue { get; set; }

        /// <summary>
        /// 生成種別
        /// "Basic"=単純型プロパティの派生表現を生成します。省略が可能です。
        /// "DependencyProperty"=依存プロパティを生成します。
        /// "UIPropertyMetadata"=依存関係プロパティを生成します。
        /// "PropertyChangedCallback"=依存関係プロパティを生成します。
        /// "GlobalVariableManager"=GlobalVariableManagerのXAMLラッパープロパティを生成します。
        /// "Command"=コマンドを生成します。
        /// "Event"=イベントを生成します。
        /// "RoutedEvent"=イベントを生成します。
        /// </summary>
        public string Kind { get; set; }

        /// <summary>
        /// コメント
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 列挙型
        /// GlobalVariableManagerのキーとなるEnum型
        /// </summary>
        public string GlobalVariableEnum { get; set; }

        /// <summary>
        /// Setterをプライベートに隠蔽
        /// </summary>
        public bool SetterPrivate { get; set; }

        /// <summary>
        /// PropertyChangedイベントを発生
        /// </summary>
        public bool RaisePropertyChanged { get; set; }

        /// <summary>
        /// Canメソッドの生成
        /// </summary>
        public bool CanGenetate { get; set; }

        /// <summary>
        /// プロパティの更新時に呼び出されるメソッドを生成
        /// </summary>
        public bool SetNotificator { get; set; }

        /// <summary>
        /// CommandParameterで受け取る型
        /// </summary>
        public Type CommandParameter { get; set; }

        /// <summary>
        /// Property変更コールバック関数の生成
        /// </summary>
        public bool PropertyChangedCallback { get; set; }

        /// <summary>
        /// ルーティングの種類
        /// </summary>
        public string RoutingStrategy { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TemplateGenerateAnnotation()
            : base()
        {
            this.Kind = "Basic";
            this.Comment = string.Empty;
            this.SetterPrivate = false;
            this.RaisePropertyChanged = false;
            this.SetNotificator = false;
            this.CommandParameter = null;
            this.PropertyChangedCallback = false;
        }
    }
}
