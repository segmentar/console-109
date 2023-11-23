using Core;

namespace Core
{
    using System;

    internal partial class ControlFlowSchedule
    {
        internal ControlFlowSchedule(Control control, Flow flow, Schedule schedule)
        {
            this.Control = control;

            this.Flow = flow;

            this.Schedule = schedule;

            return;
        }
    }
}
