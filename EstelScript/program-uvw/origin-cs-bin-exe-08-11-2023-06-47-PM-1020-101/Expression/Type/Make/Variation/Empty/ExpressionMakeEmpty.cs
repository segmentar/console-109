using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal static Expression MakeExpressionEmpty()
        {
            Expression expressionResult = default;

            var expression = new ExpressionSimple(default, default).Result;

            expressionResult = expression;

            return expressionResult;
        }
    }
}
