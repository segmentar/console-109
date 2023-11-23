using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial struct FormModule
    {
        internal static FormModule FormModuleTwo(FormModule module)
        {
            var list = new List<String>();

            foreach (Form form in module.First.FormArray)
            {
                var file = form.WriteToFile(module.ProgramModule.Third.WorkingDirectory);

                list.Add(file);

                continue;
            }

            var array = list.ToArray();

            FormModuleSecond second;

            second = new FormModuleSecond(array);

            module.Second = second;

            return module;
        }
    }
}
