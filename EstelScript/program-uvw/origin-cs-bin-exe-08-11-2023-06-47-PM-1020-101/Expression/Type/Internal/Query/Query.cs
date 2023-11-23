using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal void Query(String value)
        {
            var expression = IQuery(value);

            SetPointer(expression);

            return;
        }
    }
}
