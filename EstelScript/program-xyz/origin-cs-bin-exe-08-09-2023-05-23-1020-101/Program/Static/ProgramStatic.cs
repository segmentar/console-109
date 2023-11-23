using Core;

namespace Core
{
    using System;

    using System.Text;

    internal partial class Program
    {
        internal static String[] ArgumentArray;

        internal static void Main(params String[] array_ARGUMENT)
        {
            ArgumentArray = array_ARGUMENT;

            Bundle();

            return;
        }

        internal static void Procedure()
        {
            // DEBUG O

            Policy.FormDebugPolicy = true;

            // INFO O

            Policy.ProgramInfoPolicy = true;

            Policy.ControlFlowScheduleInfoPolicy = true;

            Policy.FormInfoPolicy = true;

            return;
        }

        internal static void Manual()
        {
            ProgramModule programModule = ProgramModule.ProgramModuleDefault();

            FormModule formModule = FormModule.FormModuleDefault(programModule);
            
            return;
        }

        internal static void Bundle()
        {
            Procedure();

            Manual();

            Raise();

            return;
        }

        internal static void Raise()
        {
            if (Policy.ProgramInfoPolicy is true)
            {
                Console.Clear();

                foreach (Program program in Policy.ProgramArrayList)
                {
                    Console.Out.WriteLine(program);

                    continue;
                }

                Console.ReadKey(true);
            }
            else
                "false".ToString();

            if (Policy.ControlFlowScheduleInfoPolicy is true)
            {
                Console.Clear();

                foreach (ControlFlowSchedule controlFlowSchedule in Policy.ControlFlowScheduleArrayList)
                {
                    Console.Out.WriteLine(controlFlowSchedule);

                    continue;
                }

                Console.ReadKey(true);
            }
            else
                "false".ToString();

            if (Policy.FormInfoPolicy is true)
            {
                Console.Clear();

                foreach (Form form in Policy.FormArrayList)
                {
                    Console.Out.WriteLine(form);

                    continue;
                }

                Console.ReadKey();
            }
            else
                "false".ToString();

            return;
        }

        static Program()
        {
            return;
        }
    }
}
