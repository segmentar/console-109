using Core;

namespace Core
{
    using System;

    internal partial struct FormData
    {
        internal FormRuntime Runtime;

        internal ControlFlowSchedule ControlFlowSchedule;

        internal Int32[] PositionArray;

        internal Boolean IsDebug;
    }
}
