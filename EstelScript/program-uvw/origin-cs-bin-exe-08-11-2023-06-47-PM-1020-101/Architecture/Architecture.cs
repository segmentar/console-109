using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal static class Architecture
    {
        internal static String ProgramName = Assembly.GetEntryAssembly().GetName().Name;

        internal static String ProgramNameSafe = String.Join(null, ProgramName.Split(Path.GetInvalidFileNameChars(), StringSplitOptions.RemoveEmptyEntries));

        internal static String WorkingDirectoryDefaultName = $"{ProgramNameSafe}_WorkingDirectory_{Path.GetRandomFileName()}";

        internal static String FormFileExtension;

        internal static Int32 StreamPositon = 1;
    }
}
