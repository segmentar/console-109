using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal partial class Program
    { 
        internal Tuple<String, String> CurrentTuple()
        {
            Tuple<String, String> tupleResult = default;

            var path_FILE_filename_with_extension__CURRENT = Assembly.GetEntryAssembly().Location;

            var path_DIRECTORY_full_name__CURRENT = Path.GetDirectoryName(path_FILE_filename_with_extension__CURRENT);

            var tuple = new Tuple<String, String>(path_FILE_filename_with_extension__CURRENT, path_DIRECTORY_full_name__CURRENT);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
