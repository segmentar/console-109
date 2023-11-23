using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal void SetPointer(Expression expression)
        {
            ExpressionPointer = expression;

            return;
        }
    }
}
