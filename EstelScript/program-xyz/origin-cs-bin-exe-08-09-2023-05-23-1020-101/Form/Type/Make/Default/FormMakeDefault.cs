using Core;

namespace Core
{
    using System;

    internal partial class Form
    {
        internal static Form MakeFormDefault(ControlFlowSchedule controlFlowSchedule, Boolean debug)
        {
            Form formResult = default;

            var result = new FormSequence(controlFlowSchedule, debug).Result;

            Policy.FormArrayList.Add(result);

            formResult = result;

            return formResult;
        }
    }
}
