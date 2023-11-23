using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal void Lock(String value)
        {
            LastLockExpression = ILock(value);

            return;
        }
    }
}
