using Core;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleFunctionTwo(ProgramModule module)
        {
            var tuple = module.Program.CurrentTuple();

            String workingDirectory;

            workingDirectory = module.Program.WorkingDirectory(tuple.Item2);

            ProgramModuleFunctionSecond second;

            second = new ProgramModuleFunctionSecond(tuple.Item1, tuple.Item2, workingDirectory);

            module.Second = second;

            return module;
        }
    }
}
