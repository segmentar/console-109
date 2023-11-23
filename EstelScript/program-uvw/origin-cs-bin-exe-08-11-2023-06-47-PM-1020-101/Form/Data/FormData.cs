using Core;

namespace Core
{
    using System;

    internal partial struct FormData
    {
        internal FormMeasure Measure;

        internal FormRuntime Runtime;

        internal Boolean EndianFormat;

        internal Int32 StringCodec;

        internal Int32 ChunkSize;

        internal Int32 StartBoundary;

        internal Boolean IsDebug;
    }
}
