using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Expression
    {
        internal Expression(Object expressionObject, ArrayList expressionList, Expression expressionPointer, Expression expressionRootPointer, Boolean debug)
        {
            this.ExpressionObject = expressionObject;

            this.ExpressionList = expressionList;

            this.ExpressionPointer = expressionPointer;

            this.ExpressionRootPointer = expressionRootPointer;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
