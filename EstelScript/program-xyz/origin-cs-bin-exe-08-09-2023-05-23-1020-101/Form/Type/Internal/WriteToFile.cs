using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Form
    {
        internal String WriteToFile(String directory)
        {
            String stringResult = default;

            var path_FILE_filename = Path.Combine(directory, Path.GetRandomFileName());

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Architecture.FullExtension);

            if (File.Exists(path_FILE_filename_with_extension))
            {
                File.Delete(path_FILE_filename_with_extension);
            }
            else
            {
                FileStream fileStream;

                MemoryStream memoryStream;

                BinaryWriter binaryWriter;

                using (memoryStream = new MemoryStream())
                {
                    using (binaryWriter = new BinaryWriter(memoryStream, Architecture.StringCodec))
                    {
                        binaryWriter.Write(Architecture.EndianFormat);

                        binaryWriter.Write(Architecture.StringCodec.CodePage);

                        binaryWriter.Write(Architecture.ChunkSize);

                        binaryWriter.Write(Architecture.StartBoundary);

                        var position = 1;

                        binaryWriter.Seek(Architecture.StartBoundary + (Architecture.ChunkSize * (position - 1)), SeekOrigin.Begin);

                        binaryWriter.Write(Data.Runtime.HeaderArray.Length);

                        position = position + 1;

                        foreach (String stringItem in Data.Runtime.HeaderArray)
                        {
                            binaryWriter.Seek(Architecture.StartBoundary + (Architecture.ChunkSize * (position - 1)), SeekOrigin.Begin);

                            binaryWriter.Write(stringItem);

                            position = position + 1;

                            continue;
                        }

                        binaryWriter.Seek(Architecture.StartBoundary + (Architecture.ChunkSize * (position - 1)), SeekOrigin.Begin);

                        binaryWriter.Write(Data.Runtime.Content);

                        position = position + 1;

                        binaryWriter.Seek(Architecture.StartBoundary + (Architecture.ChunkSize * (position - 1)), SeekOrigin.Begin);

                        binaryWriter.Write(Data.IsDebug);

                        position = position + 1;

                        binaryWriter.Close();

                        binaryWriter.Dispose();
                    }

                    var array = memoryStream.ToArray();

                    using (fileStream = File.Create(path_FILE_filename_with_extension))
                    {
                        fileStream.Write(array, 0, array.Length);                        

                        fileStream.Flush();

                        fileStream.Close();

                        fileStream.Dispose();
                    }

                    memoryStream.Flush();

                    memoryStream.Close();

                    memoryStream.Dispose();
                }
            }

            return stringResult;
        }
    }
}
