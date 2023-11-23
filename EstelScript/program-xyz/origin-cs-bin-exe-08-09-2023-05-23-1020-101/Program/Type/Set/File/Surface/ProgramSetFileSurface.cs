using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static String[] ProgramFileSetSurface(String[] directoryArray)
        {
            String[] arrayResult = default;

            var list = new List<String>(ProgramFileSet(directoryArray));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
