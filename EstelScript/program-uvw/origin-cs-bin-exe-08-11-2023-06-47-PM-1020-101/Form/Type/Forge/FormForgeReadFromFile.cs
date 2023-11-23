using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    internal partial class Form
    {
        internal static Form ForgeReadFromFile(String file)
        {
            Form formResult = default;

            FileStream fileStream;

            MemoryStream memoryStream;

            BinaryReader binaryReader;

            using (fileStream = File.OpenRead(file))
            {
                Byte[] byteArray;

                byteArray = new Byte[fileStream.Length];

                var length = fileStream.Read(byteArray, 0, byteArray.Length);

                using (memoryStream = new MemoryStream(byteArray, 0, length))
                {
                    using (binaryReader = new BinaryReader(memoryStream, Encoding.Default))
                    {
                        var form = MakeFormDefaultSurface(fileStream, memoryStream, binaryReader);

                        formResult = form;

                        binaryReader.Close();

                        binaryReader.Dispose();
                    }

                    memoryStream.Close();

                    memoryStream.Dispose();
                }

                fileStream.Close();

                fileStream.Dispose();
            }

            return formResult;
        }
    }
}
