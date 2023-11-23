using Core;

namespace Core
{
    using System;

    internal partial class ControlFlowScheduleSequence
    {
        internal static void Debug(String file, String content, Boolean debug)
        {
            if (debug is true)
            {
                var descriptor = String.Join('\n'.ToString(), new String[] { 
                    String.Empty + nameof(ControlFlowSchedule) + ' ' + "::" + ' ' + nameof(ControlFlowScheduleSequence) + ' ' + '{',
                    String.Empty + '.' + "debug",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(file) + ':' + ' ' + file,
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(content) + ':' + ' ' + content,
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(debug) + ':' + ' ' + debug,
                    String.Empty + '}'
                });

                Console.Out.WriteLine(descriptor);
            }
            else
                "false".ToString();

            return;
        }
    }
}
