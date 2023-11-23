using Core;

namespace Core
{
    using System;

    internal partial class ExpressionSimple
    {
        internal Expression Result { get; set; } = default;

        internal ExpressionSimple(Object expressionObject, params Object[] expressionArray)
        {
            var expression = Expression.MakeExpressionDefaultSurface(expressionObject, expressionArray, default);

            this.Result = expression;

            return;
        }

        ~ExpressionSimple()
        {
            return;
        }
    }
}
