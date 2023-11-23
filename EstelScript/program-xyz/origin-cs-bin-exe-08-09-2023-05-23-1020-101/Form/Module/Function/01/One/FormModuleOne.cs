using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial struct FormModule
    {
        internal static FormModule FormModuleOne(FormModule module)
        {
            FormModuleFirst first;

            var list = new List<Form>();

            foreach (ControlFlowSchedule controlFlowSchedule in ControlFlowSchedule.ControlFlowScheduleDefaultSetSurface(module.ProgramModule.Fourth.FileArray))
            {
                foreach (Form form in controlFlowSchedule.Schedule.FormList)
                {
                    list.Add(form);

                    continue;
                }

                continue;
            }

            var array = list.ToArray();
            
            first = new FormModuleFirst(array);

            module.First = first;

            return module;
        }
    }
}
