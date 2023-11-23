namespace Core
{
    using System;

    using System.Collections;

    internal partial class ExpressionSequence
    {
        internal Expression Result { get; set; } = default;

        internal ExpressionSequence(Object expressionObject, Object[] expressionArray, Expression expressionPointer, Boolean debug)
        {
            //Debug(expressionObject, expressionArray, expressionPointer, debug);

            if ((expressionObject == null || expressionObject == default) is true)
            {
                expressionObject = String.Empty;
            }
            else
                "false".ToString();

            if ((expressionArray == null || expressionArray == default) is true)
            {
                expressionArray = new Object[0];
            }
            else
                "false".ToString();

            var array = Expression.ExpressionDefaultSetSurface(expressionArray);

            var list = new ArrayList(array);

            var expression = new Expression(expressionObject, list, expressionPointer, default, debug);

            expression.InitializePointer();

            this.Result = expression;

            return;
        }

        ~ExpressionSequence()
        {
            return;
        }
    }
}
