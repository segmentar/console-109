using Core;

namespace Core
{
    using System;

    internal partial struct FormModule
    {
        internal static FormModule FormModuleFunctionOne(FormModule module)
        {
            var array = Form.ReadFromFileSetSurface(module.ProgramModule.Third.FileArray);

            FormModuleFunctionFirst first;

            first = new FormModuleFunctionFirst(array);

            module.First = first;

            return module;
        }

    }
}
