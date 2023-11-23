using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class FormMeasure
    {
        internal FileStream FileStream;

        internal MemoryStream MemoryStream;

        internal BinaryReader BinaryReader;

        internal FormMeasure(FileStream fileStream, MemoryStream memoryStream, BinaryReader binaryReader)
        {
            this.FileStream = fileStream;

            this.MemoryStream = memoryStream;

            this.BinaryReader = binaryReader;

            return;
        }

        ~FormMeasure()
        {
            return;
        }
    }
}
