using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Form
    {
        internal static Form MakeFormDefaultSurface(FileStream fileStream, MemoryStream memoryStream, BinaryReader binaryReader)
        {
            Form formResult = default;

            formResult = MakeFormDefault(fileStream, memoryStream, binaryReader, Policy.FormDebugPolicy);

            return formResult;
        }
    }
}
