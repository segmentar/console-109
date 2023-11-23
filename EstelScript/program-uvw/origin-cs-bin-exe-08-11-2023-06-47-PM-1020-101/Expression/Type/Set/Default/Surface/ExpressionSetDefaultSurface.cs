using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Expression
    {
        internal static Expression[] ExpressionDefaultSetSurface(Object[] objectArray)
        {
            Expression[] arrayResult = default;

            var list = new List<Expression>(ExpressionDefaultSet(objectArray));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
