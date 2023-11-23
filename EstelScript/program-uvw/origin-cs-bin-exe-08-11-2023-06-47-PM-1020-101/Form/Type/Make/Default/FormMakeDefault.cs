using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Form
    {
        internal static Form MakeFormDefault(FileStream fileStream, MemoryStream memoryStream, BinaryReader binaryReader, Boolean debug)
        {
            Form formResult = default;

            var result = new FormSequence(fileStream, memoryStream, binaryReader, debug).Result;

            Policy.FormArrayList.Add(result);

            formResult = result;

            return formResult;
        }
    }
}
