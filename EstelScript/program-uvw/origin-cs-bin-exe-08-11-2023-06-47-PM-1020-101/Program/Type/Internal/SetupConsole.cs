using Core;

namespace Core
{
    using System;

    internal partial class Program
    { 
        internal void SetupConsole()
        {
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();

            do
            {
                Console.Clear();

                var message = String.Join('\n'.ToString(), new String[] {
                    String.Empty,
                    String.Empty + '\t' + 'O' + ':' + ' ' + $"This is {Architecture.ProgramName}" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + 'o' + ':' + ' ' + "Enter the form file extension" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + '~' + ' ' +  nameof(Architecture.FormFileExtension) + ':' + ' ' + Architecture.FormFileExtension,
                    String.Empty,
                    String.Empty + '\t' + "Prompt" + ':' + ' ',
                    String.Empty,
                });

                Console.Out.WriteLine(message);

                Console.CursorLeft = 16;

                Console.CursorTop = 7;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);

                var line = Console.In.ReadLine();

                var lower = line.ToLower();

                if ((lower == "escape") is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Architecture.FormFileExtension = line;

                continue;

            } while (true);

            return;
        }
    }
}
