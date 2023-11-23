using Core;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleFunctionTwo(ProgramModule module)
        {
            var tuple = module.Program.CurrentSetup();

            ProgramModuleFunctionSecond second;

            second = new ProgramModuleFunctionSecond(tuple.Item1, tuple.Item2);

            module.Second = second;

            return module;
        }
    }
}
