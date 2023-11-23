using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static String[] ProgramDirectorySetSurface(String directory)
        {
            String[] arrayResult = default;

            var list = new List<String>(ProgramDirectorySet(directory));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
