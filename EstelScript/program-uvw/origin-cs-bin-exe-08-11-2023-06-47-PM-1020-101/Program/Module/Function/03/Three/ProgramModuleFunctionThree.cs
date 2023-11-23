using Core;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleFunctionThree(ProgramModule module)
        {
            var tuple = module.Program.ArrayTuple(module.Second.CurrentDirectory);

            ProgramModuleFunctionThird third;

            third = new ProgramModuleFunctionThird(tuple.Item1, tuple.Item2);

            module.Third = third;

            return module;
        }
    }
}
