using Core;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleFunctionThree(ProgramModule module)
        {
            String workingDirectory;

            workingDirectory = module.Program.WorkingDirectory(module.Second.CurrentDirectory);

            ProgramModuleFunctionThird third;

            third = new ProgramModuleFunctionThird(workingDirectory);

            module.Third = third;

            return module;
        }
    }
}
