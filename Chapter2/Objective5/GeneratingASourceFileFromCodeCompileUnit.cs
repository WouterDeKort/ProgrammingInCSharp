using System.CodeDom;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.IO;
using Microsoft.CSharp;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-75 Generating a source file from a CodeCompileUnit.")]
    internal class GeneratingASourceFileFromCodeCompileUnit : ISample

    {
        public void Run()
        {
            var compileUnit = new CodeCompileUnit();
            var myNamespace = new CodeNamespace("MyNamespace");
            myNamespace.Imports.Add(new CodeNamespaceImport("System"));
            var myClass = new CodeTypeDeclaration("MyClass");
            var start = new CodeEntryPointMethod();
            var cs1 = new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression("Console"),
                "WriteLine", new CodePrimitiveExpression("Hello World!"));

            compileUnit.Namespaces.Add(myNamespace);
            myNamespace.Types.Add(myClass);
            myClass.Members.Add(start);
            start.Statements.Add(cs1);

            var provider = new CSharpCodeProvider();

            using (var sw = new StreamWriter("HelloWorld.cs", false))
            {
                var tw = new IndentedTextWriter(sw, "    ");
                provider.GenerateCodeFromCompileUnit(compileUnit, tw,
                    new CodeGeneratorOptions());
                tw.Close();
            }
        }
    }
}