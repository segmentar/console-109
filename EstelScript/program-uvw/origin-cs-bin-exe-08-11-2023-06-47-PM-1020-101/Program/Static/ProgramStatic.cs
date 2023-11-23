using Core;

namespace Core
{
    using System;

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

            Policy.ProgramDebugPolicy = false;

            Policy.FormDebugPolicy = false;

            Policy.ExpressionDebugPolicy = false;

            // INFO O

            Policy.ProgramInfoPolicy = true;

            Policy.FormInfoPolicy = true;

            Policy.ExpressionInfoPolicy = false;

            return;
        }

        internal static void Manual()
        {
            ProgramModule programModule = ProgramModule.ProgramModuleDefault();

            FormModule formModule = FormModule.FormModuleDefault(programModule);

            ExpressionModule expressionModule = ExpressionModule.ExpressionModuleDefault(formModule);

            foreach (Expression expression in expressionModule.First.ExpressionArray)
            {
                Console.Clear();

                Console.Out.WriteLine($"baked expression -> {expression}");

                Console.ReadKey(true);
            }

            return;
        }

        internal static void Raise()
        {
            if (Policy.ProgramInfoPolicy is true)
            {
                foreach (Program program in Policy.ProgramArrayList)
                {
                    Console.Clear();

                    Console.Out.WriteLine(program);

                    Console.ReadKey(true);

                    continue;
                }
            }
            else
                "false".ToString();

            if (Policy.FormInfoPolicy is true)
            {
                foreach (Form form in Policy.FormArrayList)
                {
                    Console.Clear();

                    Console.Out.WriteLine(form);

                    Console.ReadKey(true);

                    continue;
                }
            }
            else
                "false".ToString();

            if (Policy.ExpressionInfoPolicy is true)
            {
                foreach (Expression expression in Policy.ExpressionArrayList)
                {
                    Console.Clear();

                    Console.Out.WriteLine(expression);

                    Console.ReadKey(true);

                    continue;
                }
            }
            else
                "false".ToString();

            Console.Clear();

            Console.Out.WriteLine("end-of-file");

            return;
        }
        internal static void Bundle()
        {
            Procedure();

            Manual();

            Raise();

            return;
        }
    }
}
