using Designtime.Sourcecode.Generator.Attributes;
using DesigntimeSourcecodeGenerator.Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesigntimeSourcecodeGenerator.Demo.ViewModel
{
    public class SelectChangedEventArgs : EventArgs
    {
    }

    // ロガー生成
    [TemplateGenerateAnnotation(Kind = "Logger", Comment = "Logger")]
    // 単純プロパティ生成
    [TemplateGenerateAnnotation(Name = "Age", Type = typeof(int), Comment = "年齢")]
    // プロパティのSetterをprivateにして生成
    [TemplateGenerateAnnotation(Name = "Name", Type = typeof(string), Comment = "名前", SetterPrivate = true)]
    // PropertyChangedイベントを発火するプロパティを生成
    [TemplateGenerateAnnotation(Name = "Attached", Type = typeof(string), Comment = "所属", RaisePropertyChanged = true)]
    // 更新通知メソッドを呼び出すプロパティを生成。SchoolNotification()
    [TemplateGenerateAnnotation(Name = "School", Type = typeof(string), Comment = "学校", RaisePropertyChanged = true, SetNotificator = true)]
    // コマンドの生成
    [TemplateGenerateAnnotation(Name = "Click", Kind = "Command", Comment = "クリック")]
    // コマンドの生成（CanPushメソッドも生成）
    [TemplateGenerateAnnotation(Name = "Click2", Kind = "Command", CanGenetate = true, Comment = "クリック2")]
    // コマンドの生成（CommandParameterを受け取れるメソッドを生成）
    [TemplateGenerateAnnotation(Name = "Click3", Kind = "Command", Comment = "クリック3", CommandParameter = typeof(string))]
    // イベントの生成
    [TemplateGenerateAnnotation(Name = "SelectChanged", Kind = "Event", Comment = "選択変更")]
    public partial class MainWindowViewModel : Livet.ViewModel
    {
        public MainWindowViewModel()
        {
            var model = MainWindowModel.Instance;

            this.Age = 17;
            this.Name = "elf";
            this.Attached = "特務機関";
            this.School = "稲豊市立稲豊中学校";
        }

        /// <summary>
        /// 更新通知メソッドを呼び出すプロパティを生成。SchoolNotification()
        /// </summary>
        private void SchoolNotification()
        {
        }

        /// <summary>
        /// コマンドの生成
        /// </summary>
        private void Click()
        {
        }

        /// <summary>
        /// コマンドの生成（CanPushメソッドも生成）
        /// </summary>
        private void Click2()
        {
        }
        private bool CanClick2()
        {
            return true;
        }

        /// <summary>
        /// コマンドの生成（CommandParameterを受け取れるメソッドを生成）
        /// </summary>
        /// <param name="message"></param>
        private void Click3(string message)
        {
        }
    }
}
