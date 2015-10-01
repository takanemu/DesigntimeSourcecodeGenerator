namespace DesigntimeSourcecodeGenerator.Test.Model
{
    using Designtime.Sourcecode.Generator.Attributes;

    [TemplateGenerateAnnotation(Kind = "Logger", Comment = "Logger")]
    public partial class TestClass
    {
        public TestClass()
        {
        }
    }

    [TemplateGenerateAnnotation(Kind = "Logger", Comment = "Logger")]
    [TemplateGenerateAnnotation(Kind = "Singleton", Comment = "Singleton")]
    public partial class MainWindowModel
    {
        static void StaticConstructor()
        {
        }

        private void InstanceConstructor()
        {
        }
    }

    [TemplateGenerateAnnotation(Kind = "Logger", Comment = "Logger")]
    public partial class SubClass
    {
    }
}
