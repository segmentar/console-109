using Core;

namespace Core
{
    using System;

    internal partial class Form
    {
        internal static void AdvanceStreamPositionVoid(Int32 value)
        {
            Architecture.StreamPositon = Architecture.StreamPositon + value;

            return;
        }
    }
}
