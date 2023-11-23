using Core;

namespace Core
{
    using System;

    internal partial class ControlFlowSchedule
    {
        internal static ControlFlowSchedule MakeCFSDefaultSurface(String file, String content)
        {
            ControlFlowSchedule controlFlowScheduleResult = default;

            controlFlowScheduleResult = MakeControlFlowScheduleDefault(file, content, Policy.ControlFlowScheduleDebugPolicy);

            return controlFlowScheduleResult;
        }
    }
}
