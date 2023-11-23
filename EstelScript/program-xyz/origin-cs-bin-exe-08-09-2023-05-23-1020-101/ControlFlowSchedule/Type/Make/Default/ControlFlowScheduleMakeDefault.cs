using Core;

namespace Core
{
    using System;

    internal partial class ControlFlowSchedule
    {
        internal static ControlFlowSchedule MakeControlFlowScheduleDefault(String file, String content, Boolean debug)
        {
            ControlFlowSchedule controlFlowScheduleResult = default;

            var result = new ControlFlowScheduleSequence(file, content, debug).Result;

            Policy.ControlFlowScheduleArrayList.Add(result);

            controlFlowScheduleResult = result;

            return controlFlowScheduleResult;
        }
    }
}
