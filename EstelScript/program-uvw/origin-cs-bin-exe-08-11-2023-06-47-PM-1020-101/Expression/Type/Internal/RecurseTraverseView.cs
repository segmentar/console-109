using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Expression
    {
        internal String RecurseTraverseView()
        {
            String stringResult = default;

            stringResult = RecurseTraverseViewOneFirst(1, String.Empty, this, this.ExpressionObject, this.ExpressionList);

            return stringResult;
        }

        internal String RecurseTraverseViewOneFirst(Int32 layer, String builder, Expression expression, Object expressionObject, ArrayList expressionList)
        {
            String stringResult = default;

            var message = new String('>', layer) + ' ' + expressionObject + '\n';

            builder = builder + message;

            foreach (Object object_ITEM in expressionList)
            {
                var reflect = (object_ITEM as Expression);

                var layer_NEXT = (layer + 1);

                builder = RecurseTraverseViewOneFirst(layer_NEXT, builder, reflect, reflect.ExpressionObject, reflect.ExpressionList);

                continue;
            }

            stringResult = builder;

            return stringResult;
        }
    }
}
