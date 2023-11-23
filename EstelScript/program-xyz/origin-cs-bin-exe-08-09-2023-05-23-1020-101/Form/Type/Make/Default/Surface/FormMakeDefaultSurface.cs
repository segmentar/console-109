using Core;

namespace Core
{
    using System;

    internal partial class Form
    {
        internal static Form MakeFormDefaultSurface(ControlFlowSchedule controlFlowSchedule)
        {
            Form formResult = default;

            formResult = MakeFormDefault(controlFlowSchedule, Policy.FormDebugPolicy);

            return formResult;
        }
    }
}
