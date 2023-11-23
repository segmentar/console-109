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

            if ((Architecture.ExtensionName == null) is false)
            {
                Architecture.DefaultWorkingDirectoryName = $"{Architecture.ExtensionName}_{Path.GetRandomFileName()}";
            }
            else
                "false".ToString();

            var path_DIRECTORY_full_name = Path.Combine(currentDirectory, Architecture.DefaultWorkingDirectoryName);

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
