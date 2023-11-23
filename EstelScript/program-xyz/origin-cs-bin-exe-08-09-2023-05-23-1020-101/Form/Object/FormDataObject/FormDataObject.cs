using Core;

namespace Core
{
    using System;

    internal partial struct FormData
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormData) + ' ' + '{',
                String.Empty + '.' + "data",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Runtime) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ControlFlowSchedule) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(PositionArray) + ':' + ' ' + ". . ." + ' ' + $"[{PositionArray.Length}]",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}',
                String.Empty,
                String.Empty + nameof(Runtime) + ':',
                String.Empty + Runtime,
                String.Empty,
                String.Empty + nameof(ControlFlowSchedule) + ':',
                String.Empty + ControlFlowSchedule.GetHashCode(),
                String.Empty,
                String.Empty + nameof(PositionArray) + ':',
                String.Empty + String.Join('\n'.ToString(), PositionArray)
            });
        }
    }
}
