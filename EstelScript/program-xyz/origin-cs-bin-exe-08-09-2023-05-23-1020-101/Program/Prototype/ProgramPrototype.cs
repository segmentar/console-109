using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal Program(Boolean debug)
        {
            ProgramData data;

            data = new ProgramData();

            if (debug is true)
            {
                data.IsDebug = true;
            }
            else
                "false".ToString();

            this.Data = data;

            return;
        }
    }
}
