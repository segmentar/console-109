using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class ControlFlowSchedule
    {
        internal static ControlFlowSchedule[] ControlFlowScheduleDefaultSetSurface(String[] fileArray)
        {
            ControlFlowSchedule[] arrayResult = default;

            var list = new List<ControlFlowSchedule>(ControlFlowScheduleDefaultSet(fileArray));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
