using Core;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleFunctionFour(ProgramModule module)
        {
            var tuple = module.Program.RecurseTraverseDirectoryFileTuple(module.Second.CurrentDirectory);

            String[] directoryArray, fileArray;

            directoryArray = tuple.Item1;

            fileArray = tuple.Item2;

            ProgramModuleFunctionFourth fourth;

            fourth = new ProgramModuleFunctionFourth(directoryArray, fileArray);

            module.Fourth = fourth;

            return module;
        }
    }
}
