using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class FormSequence
    {
        internal Form Result { get; set; } = default;

        internal FormSequence(FileStream fileStream, MemoryStream memoryStream, BinaryReader binaryReader, Boolean debug)
        {
            Debug(fileStream, memoryStream, binaryReader, debug);

            var endianFormat = binaryReader.ReadBoolean();

            var stringCodec = binaryReader.ReadInt32();

            var chunkSize = binaryReader.ReadInt32();

            var startBoundary = binaryReader.ReadInt32();

            FormMeasure measure;

            measure = new FormMeasure(fileStream, memoryStream, binaryReader);

            var form = new Form(measure, endianFormat, stringCodec, chunkSize, startBoundary, debug);

            this.Result = form;

            return;
        }

        ~FormSequence()
        {
            return;
        }
    }
}
