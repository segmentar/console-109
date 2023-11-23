using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class ControlFlowSchedule
    {
        internal static IList<ControlFlowSchedule> ControlFlowScheduleDefaultSet(String[] fileArray)
        {
            ICollection<ControlFlowSchedule> collectionResult = default;

            collectionResult = new Collection<ControlFlowSchedule>();

            foreach (String file in fileArray)
            {
                var text = File.ReadAllText(file);

                ControlFlowSchedule controlFlowSchedule;

                controlFlowSchedule = MakeCFSDefaultSurface(file, text);

                do
                {
                    if ((controlFlowSchedule.Flow.Position == controlFlowSchedule.Control.Content.Length) is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var form = Form.MakeFormDefaultSurface(controlFlowSchedule);

                    if ((form == default) is false)
                    {
                        controlFlowSchedule.Schedule.FormList.Add(form);
                    }
                    else
                        "false".ToString();

                    controlFlowSchedule.Flow.Position = controlFlowSchedule.Flow.Position + 1;

                    continue;

                } while (true);

                collectionResult.Add(controlFlowSchedule);

                continue;
            }

            return new List<ControlFlowSchedule>(collectionResult);
        }
    }
}
