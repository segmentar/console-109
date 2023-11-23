using Core;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleDefault()
        {
            ProgramModule module;

            module = new ProgramModule();

            module.Program = Program.MakeProgramDefaultSurface();

            module = ProgramModuleFunctionOne(module);

            module = ProgramModuleFunctionTwo(module);

            module = ProgramModuleFunctionThree(module);

            return module;
        }
    }
}
