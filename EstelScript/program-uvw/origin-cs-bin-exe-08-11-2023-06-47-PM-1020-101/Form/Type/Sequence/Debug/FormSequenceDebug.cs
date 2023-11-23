using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class FormSequence
    {
        internal static void Debug(FileStream fileStream, MemoryStream memoryStream, BinaryReader binaryReader, Boolean debug)
        {
            if (Policy.FormDebugPolicy is true)
            {
                var descriptor = String.Join('\n'.ToString(), new String[] {
                    String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormSequence) + ' ' + '{',
                    String.Empty + '.' + "debug",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(fileStream) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(memoryStream) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(binaryReader) + ':' + ' ' + ". . .",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(fileStream) + ':',
                    String.Empty + fileStream,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(memoryStream) + ':',
                    String.Empty + memoryStream,
                    String.Empty,
                    String.Empty + '~' + "30" + ' ' + nameof(binaryReader) + ':',
                    String.Empty + binaryReader
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
