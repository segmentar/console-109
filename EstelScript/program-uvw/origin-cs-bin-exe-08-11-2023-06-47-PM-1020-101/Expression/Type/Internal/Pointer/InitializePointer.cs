using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal void InitializePointer()
        {
            ExpressionPointer = this;

            ExpressionRootPointer = this;

            return;
        }
    }
}
