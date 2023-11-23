using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal Tuple<String[], String[]> ArrayTuple(String currentDirectory)
        {
            Tuple<String[], String[]> tupleResult = default;

            String[] directoryArray, fileArray;

            directoryArray = ProgramDirectorySetSurface(currentDirectory);

            fileArray = ProgramFileSetSurface(directoryArray);

            var tuple = new Tuple<String[], String[]>(directoryArray, fileArray);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
