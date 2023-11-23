using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class FormRuntime
    {
        internal static void ContentRuntime(FormData data)
        {
            data.Measure.BinaryReader.BaseStream.Seek(Form.ForgeStreamPosition(data.StartBoundary, data.ChunkSize, Architecture.StreamPositon, 0), SeekOrigin.Begin);

            var result = data.Measure.BinaryReader.ReadString();

            Form.AdvanceStreamPositionVoid(1);

            data.Runtime.Content = result;

            return;
        }
    }
}
