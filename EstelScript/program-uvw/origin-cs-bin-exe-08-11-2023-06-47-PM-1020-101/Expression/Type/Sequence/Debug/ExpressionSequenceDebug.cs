using Core;

namespace Core
{
    using System;
    internal partial class ExpressionSequence
    {
        internal static void Debug(Object expressionObject, Object[] expressionArray, Expression expressionPointer, Boolean debug)
        {
            if (debug is true)
            {
                var descriptor = String.Join('\n'.ToString(), new String[] {
                    String.Empty + nameof(Expression) + ' ' + "::" + ' ' + nameof(ExpressionSequence) + ' ' + '{',
                    String.Empty + '.' + "debug",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(expressionObject) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(expressionArray) + ':' + ' ' + ". . ." + ' ' + $"<{expressionArray.Length}>",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(expressionPointer) + ':' + ' ' + $"<{expressionPointer == null}>",
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(debug) + ':' + ' ' + debug,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(expressionObject) + ':',
                    String.Empty + expressionObject,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(expressionArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), expressionArray)
                });

                Console.Clear();

                Console.Out.WriteLine(descriptor);

                Console.ReadKey(true);
            }
            else
                "false".ToString();

            return;
        }
    }
}
