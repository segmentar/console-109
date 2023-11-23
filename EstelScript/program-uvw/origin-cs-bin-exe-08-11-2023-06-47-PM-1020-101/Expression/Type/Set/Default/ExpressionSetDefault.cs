using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Expression
    {
        internal static IList<Expression> ExpressionDefaultSet(Object[] objectArray)
        {
            ICollection<Expression> collectionResult = default;

            collectionResult = new Collection<Expression>();

            foreach (Object object_ITEM in objectArray)
            {
                var expression = new ExpressionSimple(object_ITEM, default).Result;

                collectionResult.Add(expression);

                continue;
            }

            return new List<Expression>(collectionResult);
        }
    }
}
