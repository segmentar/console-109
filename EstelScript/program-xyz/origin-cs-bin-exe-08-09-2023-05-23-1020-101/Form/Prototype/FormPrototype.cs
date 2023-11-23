using Core;

namespace Core
{
    using System;

    internal partial class Form
    {
        internal Form(FormData data)
        {
            data.Runtime = new FormRuntime();

            FormRuntime.SplitHeader(data);

            FormRuntime.SplitHeaderSafe(data);

            FormRuntime.ContentSubstring(data);
            
            FormRuntime.ContentSubstringSafe(data);

            FormRuntime.AdvanceControlFlowSchedule(data);

            this.Data = data;

            return;
        }

        internal Form(ControlFlowSchedule controlFlowSchedule, Int32[] positionArray, Boolean debug)
        {
            FormData data;

            data = new FormData();

            data.ControlFlowSchedule = controlFlowSchedule;

            data.PositionArray = positionArray;

            if (debug is true)
            {
                data.IsDebug = true;
            }
            else
                "false".ToString();

            Form form;

            form = new Form(data);

            this.Data = form.Data;

            return;
        }
    }
}
