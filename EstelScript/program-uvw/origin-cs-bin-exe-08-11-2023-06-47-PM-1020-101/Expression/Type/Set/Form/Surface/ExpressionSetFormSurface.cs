using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Expression
    {
        internal static Expression[] ExpressionFormSetSurface(Form[] formArray)
        {
            Expression[] arrayResult = default;

            var list = new List<Expression>(ExpressionFormSet(formArray));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
