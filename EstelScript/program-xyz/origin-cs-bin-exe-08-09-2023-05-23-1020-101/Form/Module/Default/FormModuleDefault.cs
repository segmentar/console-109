﻿using Core;

namespace Core
{
    using System;

    internal partial struct FormModule
    {
        internal static FormModule FormModuleDefault(ProgramModule programModule)
        {
            FormModule module;

            module = new FormModule();

            module.ProgramModule = programModule;

            module = FormModuleOne(module);

            module = FormModuleTwo(module);

            return module;
        }
    }
}
