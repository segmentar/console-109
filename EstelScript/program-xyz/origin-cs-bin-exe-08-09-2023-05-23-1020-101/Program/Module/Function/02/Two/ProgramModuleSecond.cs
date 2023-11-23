using Core;

namespace Core
{
    using System;

    internal partial class ProgramModuleFunctionSecond
    {
        internal String CurrentFile;

        internal String CurrentDirectory;

        internal ProgramModuleFunctionSecond(String currentFile, String currentDirectory)
        {
            this.CurrentFile = currentFile;

            this.CurrentDirectory = currentDirectory;

            return;
        }

        ~ProgramModuleFunctionSecond()
        {
            return;
        }
    }
}
