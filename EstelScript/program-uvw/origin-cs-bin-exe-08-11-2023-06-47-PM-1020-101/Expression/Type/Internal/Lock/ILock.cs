using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal Expression ILock(String value)
        {
            Expression expressionResult = default;

            var contain = false;

            foreach (Expression childExpression in ExpressionPointer.ExpressionList)
            {
                if ((childExpression.ExpressionObject.ToString() == value) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                contain = true;

                continue;
            }

            if (contain is false)
            {
                var expression = new ExpressionSimple(value, default).Result;

                ExpressionPointer.ExpressionList.Add(expression);

                expressionResult = expression;
            }
            else
                "false".ToString();

            return expressionResult;
        }
    }
}
