using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal void Release()
        {
            SetPointer(ExpressionRootPointer);

            return;
        }
    }
}
