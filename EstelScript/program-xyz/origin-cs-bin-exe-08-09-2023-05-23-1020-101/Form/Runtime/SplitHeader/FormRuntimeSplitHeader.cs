using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class FormRuntime
    {
        internal static void SplitHeader(FormData data)
        {
            var difference = (data.PositionArray[0] - data.ControlFlowSchedule.Flow.Position);

            data.Runtime.StringArray[0] = data.ControlFlowSchedule.Control.Content.Substring(data.ControlFlowSchedule.Flow.Position, difference);

            var split = data.Runtime.StringArray[0].Split(new String[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            data.Runtime.HeaderArray = split;

            return;
        }
    }
}
