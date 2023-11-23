using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal Tuple<String[], String[]> RecurseTraverseDirectoryFileTuple(String directory)
        {
            Tuple<String[], String[]> tupleResult = default;

            var array_DIRECTORY = ProgramDirectorySetSurface(directory);

            var array_FILE = ProgramFileSetSurface(array_DIRECTORY);

            var tuple = new Tuple<String[], String[]>(array_DIRECTORY, array_FILE);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
