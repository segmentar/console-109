using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal static Expression MakeExpressionRule()
        {
            Expression expressionResult = default;

            var expression = MakeExpressionRoot();

            expression.Unlock("self");

            expression.Lock("static");

            expression.Lock("execute");

            expression.Lock("dynamic");

            expression.Release();

            expression.Unlock("other");

            expression.Lock("void");

            expression.Release();

            expressionResult = expression;

            return expressionResult;
        }
    }
}
