using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal static Expression MakeExpressionDefault(Object expressionObject, Object[] expressionArray, Expression expressionPointer, Boolean debug)
        {
            Expression expressionResult = default;

            var result = new ExpressionSequence(expressionObject, expressionArray, expressionPointer, debug).Result;

            Policy.ExpressionArrayList.Add(result);

            expressionResult = result;

            return expressionResult;
        }
    }
}
