using Core;

namespace Core
{
    using System;

    internal partial struct ExpressionModule
    {
        internal static ExpressionModule ExpressionModuleFunctionOne(ExpressionModule module)
        {
            Expression[] expressionArray;

            expressionArray = Expression.ExpressionFormSetSurface(module.FormModule.First.FormArray);

            ExpressionModuleFunctionFirst first;

            first = new ExpressionModuleFunctionFirst(expressionArray);

            module.First = first;

            return module;
        }
    }
}
