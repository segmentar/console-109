using Core;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleFunctionOne(ProgramModule module)
        {
            module.Program.SetupConsole();

            ProgramModuleFunctionFirst first;

            first = new ProgramModuleFunctionFirst();

            module.First = first;

            return module;
        }
    }
}
