using Core;

namespace Core
{
    using System;

    internal partial class FormSequence
    {
        internal static void Debug(ControlFlowSchedule cfs, Boolean debug)
        {
            if (debug is true)
            {
                var descriptor = String.Join('\n'.ToString(), new String[] {
                    String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormSequence) + ' ' + '{',
                    String.Empty + '.' + "debug",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(cfs) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(debug) + ':' + ' ' + debug,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(cfs) + ':',
                    String.Empty + cfs
                });

                Console.Out.WriteLine(descriptor);
            }
            else
                "false".ToString();

            return;
        }
    }
}
