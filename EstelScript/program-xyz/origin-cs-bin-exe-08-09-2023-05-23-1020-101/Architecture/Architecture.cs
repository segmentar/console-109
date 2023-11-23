using Core;

namespace Core
{
    using System;

    using System.Text;

    using System.Reflection;

    internal static class Architecture
    {
        internal static String ProgramName = Assembly.GetEntryAssembly().GetName().Name;

        internal static String ExtensionName = "sample";

        internal static Boolean EndianFormat = BitConverter.IsLittleEndian;

        internal static Encoding StringCodec = Encoding.Default;

        internal static Int32 ChunkSize = 512;

        internal static Int32 StartBoundary = 256;

        internal static String FullExtension;

        internal static String DefaultWorkingDirectoryName = "DefaultWorkingDirectory";
    }
}
