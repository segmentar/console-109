using Core;

namespace Core
{
    using System;

    internal partial class FormRuntime
    {
        internal static void ContentSubstring(FormData data)
        {
            var difference = (data.PositionArray[1] - data.PositionArray[0]);

            var sub = data.ControlFlowSchedule.Control.Content.Substring(data.PositionArray[0], difference);

            data.Runtime.Content = sub;

            return;
        }
    }
}
