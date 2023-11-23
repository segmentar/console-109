using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class FormRuntime
    {
        internal static void NumberOfItemsInHeaderArrayRuntime(FormData data)
        {
            data.Measure.BinaryReader.BaseStream.Seek(Form.ForgeStreamPosition(data.StartBoundary, data.ChunkSize, Architecture.StreamPositon, 0), SeekOrigin.Begin);

            var integer = data.Measure.BinaryReader.ReadInt32();

            Form.AdvanceStreamPositionVoid(1);

            data.Runtime.NumberOfItemsInHeaderArray = integer;

            return;
        }
    }
}
