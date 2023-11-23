using Core;

namespace Core
{
    using System;

    internal partial class ProgramModuleFunctionThird
    {
        internal String[] DirectoryArray;

        internal String[] FileArray;

        internal ProgramModuleFunctionThird(String[] directoryArray, String[] fileArray)
        {
            this.DirectoryArray = directoryArray;

            this.FileArray = fileArray;

            return;
        }

        ~ProgramModuleFunctionThird()
        {
            return;
        }
    }
}
