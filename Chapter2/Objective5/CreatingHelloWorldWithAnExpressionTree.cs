using System;
using System.ComponentModel;
using System.Linq.Expressions;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-78 Creating “Hello World!” with an expression tree.")]
    internal class CreatingHelloWorldWithAnExpressionTree : ISample

    {
        public void Run()
        {
            BlockExpression blockExpr = Expression.Block(
                Expression.Call(
                    null,
                    typeof (Console).GetMethod("Write", new[] {typeof (String)}),
                    Expression.Constant("Hello ")
                    ),
                Expression.Call(
                    null,
                    typeof (Console).GetMethod("WriteLine", new[] {typeof (String)}),
                    Expression.Constant("World!")
                    )
                );

            Expression.Lambda<Action>(blockExpr).Compile()();
        }
    }
}