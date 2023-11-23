using Core;

namespace Core
{
    using System;

    using System.Text;

    internal partial class Program
    {
        internal void ConsoleSetup()
        {
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();
            
            do
            {
                Architecture.FullExtension = $"{Architecture.ExtensionName}_{Architecture.EndianFormat}_{Architecture.StringCodec.CodePage}_{Architecture.ChunkSize}_{Architecture.StartBoundary}";

                Console.Clear();

                var message = String.Join('\n'.ToString(), new String[] {
                    String.Empty,
                    String.Empty + '\t' + 'O' + ':' + ' ' + $"This is `{Architecture.ProgramName}`" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '1' + ':' + ' ' + "Use `set-extension-name <name>` to set extension" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '2' + ':' + ' ' + "Use `set-endian-format` <boolean> to set endian format" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '3' + ':' + ' ' + "Use `set-string-codec <codec>` to set the string codec" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '4' + ':' + ' ' + "Use `set-chunk-size <size>` to set the chunk size" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '5' + ':' + ' ' + "Use `set-start-boundary` <offset> to set start boundary" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + 'o' + ':' + ' ' + "Enter `escape` to continue execution" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + '~' + ' ' + nameof(Architecture.ExtensionName) + ':' + ' ' + Architecture.ExtensionName,
                    String.Empty,
                    String.Empty + '\t' + '~' + ' ' + nameof(Architecture.EndianFormat) + ':' + ' ' + Architecture.EndianFormat,
                    String.Empty,
                    String.Empty + '\t' + '~' + ' ' + nameof(Architecture.StringCodec) + ':' + ' ' + Architecture.StringCodec,
                    String.Empty,
                    String.Empty + '\t' + '~' + ' ' + nameof(Architecture.ChunkSize) + ':' + ' ' + Architecture.ChunkSize,
                    String.Empty,
                    String.Empty + '\t' + '~' + ' ' + nameof(Architecture.StartBoundary) + ':' + ' ' + Architecture.StartBoundary,
                    String.Empty,
                    String.Empty + '\t' + '~' + ' ' + nameof(Architecture.FullExtension) + ':' + ' ' + Architecture.FullExtension,
                    String.Empty,
                    String.Empty + '\t' + $"(size of header is 13 bytes) Prompt" + ':' + ' ',
                    String.Empty
                });

                Console.Out.WriteLine(message);

                Console.CursorLeft = 45;

                Console.CursorTop = 27;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);

                var line = Console.In.ReadLine();

                var lower = line.ToLower();

                var split = lower.Split();

                if ((split.Length == 2) is true)
                {
                    var first = split[0];

                    var second = split[1];

                    if ((first == "set-extension-name") is true)
                    {
                        Architecture.ExtensionName = second;
                    }
                    else
                        "false".ToString();

                    if ((first == "set-endian-format") is true)
                    {
                        Architecture.EndianFormat = Boolean.Parse(second);
                    }
                    else
                        "false".ToString();

                    if ((first == "set-string-codec") is true)
                    {
                        Architecture.StringCodec = Encoding.GetEncoding(second);
                    }
                    else
                        "false".ToString();

                    if ((first == "set-chunk-size") is true)
                    {
                        var value = Int32.Parse(second);

                        Architecture.ChunkSize = value;
                    }
                    else
                        "false".ToString();

                    if ((first == "set-start-boundary") is true)
                    {
                        var value = Int32.Parse(second);

                        Architecture.StartBoundary = value;
                    }
                    else
                        "false".ToString();
                }
                else
                    "false".ToString();

                if ((lower == "escape") is true)
                {
                    Console.Clear();

                    break;
                }
                else
                    "false".ToString();

                continue;

            } while (true);

            return;
        }
    }
}
