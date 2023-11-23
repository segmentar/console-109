using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class ControlFlowScheduleSequence
    {
        internal ControlFlowSchedule Result { get; set; } = default;

        internal ControlFlowScheduleSequence(String file, String content, Boolean debug)
        {
            Debug(file, content, debug);

            Control control;

            Flow flow;

            Schedule schedule;

            var list = new List<Form>();

            control = new Control(file, content);

            flow = new Flow();

            schedule = new Schedule(list);

            ControlFlowSchedule controlFlowSchedule;

            controlFlowSchedule = new ControlFlowSchedule(control, flow, schedule);

            this.Result = controlFlowSchedule;

            return;
        }

        ~ControlFlowScheduleSequence()
        {
            return;
        }
    }
}
