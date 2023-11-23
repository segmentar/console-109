using Core;

namespace Core
{
    using System;

    internal partial class ControlFlowSchedule
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
                String.Empty + nameof(ControlFlowSchedule) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Control.Filename) + ':' + ' ' + Control.Filename,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Control.Content) + ':' + ' ' + Control.Content,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Flow.Position) + ':' + ' ' + Flow.Position,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Schedule.FormList) + ':' + ' ' + ". . ." + ' ' + $"[{Schedule.FormList.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Schedule.FormList) + ':',
                String.Empty + String.Join('\n'.ToString(), Schedule.FormList)
            });
        }
    }
}
