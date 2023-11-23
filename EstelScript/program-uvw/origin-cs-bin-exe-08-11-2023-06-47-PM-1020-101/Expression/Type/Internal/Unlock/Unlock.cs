using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal void Unlock(String value)
        {
            var expression = ILock(value);

            SetPointer(expression);

            return;
        }
    }
}
