using Core;

namespace Core
{
    using System;

    internal partial class FormRuntime
    {
        internal static void AdvanceControlFlowSchedule(FormData data)
        {
            data.ControlFlowSchedule.Flow.Position = (data.PositionArray[1] + ".....".Length);

            data.ControlFlowSchedule.Flow.Position = data.ControlFlowSchedule.Flow.Position - 1;

            return;
        }
    }
}
