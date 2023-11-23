using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Form
    {
        internal static Form[] ReadFromFileSetSurface(String[] fileArray)
        {
            Form[] arrayResult = default;

            var list = new List<Form>(ReadFromFileSet(fileArray));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
