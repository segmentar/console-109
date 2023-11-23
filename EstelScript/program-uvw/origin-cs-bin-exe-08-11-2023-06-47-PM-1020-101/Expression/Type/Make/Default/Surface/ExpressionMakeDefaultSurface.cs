using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal static Expression MakeExpressionDefaultSurface(Object expressionObject, Object[] expressionArray, Expression expressionPointer)
        {
            Expression expressionResult = default;

            expressionResult = MakeExpressionDefault(expressionObject, expressionArray, expressionPointer, Policy.ProgramDebugPolicy);

            return expressionResult;
        }
    }
}
