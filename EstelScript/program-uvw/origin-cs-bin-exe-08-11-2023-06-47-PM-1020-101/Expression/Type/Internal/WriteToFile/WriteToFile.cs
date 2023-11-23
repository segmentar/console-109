using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Expression
    {
        internal void WriteToFile(String file)
        {
            FileStream fileStream;

            MemoryStream memoryStream;

            BinaryWriter binaryWriter;

            using (fileStream = File.Create(file))
            { 
                using (memoryStream = new MemoryStream())
                {
                    using (binaryWriter = new BinaryWriter(memoryStream))
                    {
                        binaryWriter.Close();

                        binaryWriter.Dispose();
                    }

                    memoryStream.Close();

                    memoryStream.Dispose();
                }

                fileStream.Flush();

                fileStream.Close();

                fileStream.Dispose();
            }

            return;
        }
    }
}
