using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal static Expression SpaceExpression = MakeExpressionRoot();

        internal static Expression LastLockExpression = MakeExpressionEmpty();
    }
}
