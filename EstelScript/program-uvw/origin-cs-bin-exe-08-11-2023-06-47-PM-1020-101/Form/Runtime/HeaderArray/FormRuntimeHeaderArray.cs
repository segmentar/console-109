using Core;

namespace Core
{
    using System;

    internal partial class FormRuntime
    {
        internal static void HeaderArrayRuntime(FormData data)
        {
            var length = data.Runtime.NumberOfItemsInHeaderArray;

            String[] stringArray;

            stringArray = new String[length];

            var indexer = 0;

            do
            {
                if ((indexer == length) is true)
                {
                    break;
                }
                else
                    "false".ToString();

                data.Measure.BinaryReader.BaseStream.Seek(Form.ForgeStreamPosition(data.StartBoundary, data.ChunkSize, 2, indexer), System.IO.SeekOrigin.Begin);

                var result = data.Measure.BinaryReader.ReadString();

                stringArray[indexer] = result;

                indexer = indexer + 1;

            } while (true);

            Form.AdvanceStreamPositionVoid(length);

            data.Runtime.HeaderArray = stringArray;

            return;
        }
    }
}
