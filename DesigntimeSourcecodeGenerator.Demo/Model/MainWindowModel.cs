using Designtime.Sourcecode.Generator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigntimeSourcecodeGenerator.Demo.Model
{
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
}
