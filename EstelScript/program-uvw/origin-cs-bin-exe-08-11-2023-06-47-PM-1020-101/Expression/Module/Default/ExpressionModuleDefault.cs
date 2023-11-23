using Core;

namespace Core
{
    using System;

    internal partial struct ExpressionModule
    {
        internal static ExpressionModule ExpressionModuleDefault(FormModule formModule)
        {
            ExpressionModule module;

            module = new ExpressionModule();

            module.FormModule = formModule;

            module = ExpressionModuleFunctionOne(module);

            return module;
        }
    }
}
