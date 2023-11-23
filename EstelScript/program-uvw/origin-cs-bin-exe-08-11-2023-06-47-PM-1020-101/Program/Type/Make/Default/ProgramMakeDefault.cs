using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static Program MakeProgramDefault(Boolean debug)
        {
            Program programResult = default;

            var result = new ProgramSequence(debug).Result;

            Policy.ProgramArrayList.Add(result);

            programResult = result;

            return programResult;
        }
    }
}
