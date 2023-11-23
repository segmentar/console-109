using Core;

namespace Core
{
    using System;

    internal partial class ProgramModuleFunctionSecond
    {
        internal String CurrentFile;

        internal String CurrentDirectory;

        internal String WorkingDirectory;

        internal ProgramModuleFunctionSecond(String currentFile, String currentDirectory, String workingDirectory)
        {
            this.CurrentFile = currentFile;

            this.CurrentDirectory = currentDirectory;

            this.WorkingDirectory = workingDirectory;

            return;
        }

        ~ProgramModuleFunctionSecond()
        {
            return;
        }
    }
}
