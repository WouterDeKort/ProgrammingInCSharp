using System.CodeDom;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-74 Generating “Hello World!” with the CodeDOM.")]
    internal class GeneratingHelloWorldWithTheCodeDOM : ISample

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
        }
    }
}