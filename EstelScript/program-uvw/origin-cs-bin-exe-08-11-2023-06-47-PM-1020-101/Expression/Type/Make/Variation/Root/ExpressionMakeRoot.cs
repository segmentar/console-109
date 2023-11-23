using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal static Expression MakeExpressionRoot()
        {
            Expression expressionResult = default;

            var expression = new ExpressionSimple("root", default).Result;

            expressionResult = expression;

            return expressionResult;
        }
    }
}
