using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal Expression IQuery(String value)
        {
            Expression expressionResult = default;

            foreach (Expression childExpression in ExpressionList)
            {
                if ((childExpression.ExpressionObject.ToString() == value) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                expressionResult = childExpression;

                return expressionResult;
            }

            foreach (Expression childExpression in ExpressionList)
            {
                expressionResult = childExpression.IQuery(value);

                if ((expressionResult == default) is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                return expressionResult;
            }

            return expressionResult;
        }
    }
}
