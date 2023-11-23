using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal String WorkingDirectory(String currentDirectory)
        {
            String stringResult = default;

            var path_DIRECTORY_full_name = Path.Combine(currentDirectory, Architecture.WorkingDirectoryDefaultName);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            stringResult = path_DIRECTORY_full_name;

            return stringResult;
        }
    }
}
