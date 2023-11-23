using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Form
    {
        internal static Form[] FormDefaultSetSurface(String[] fileArray)
        {
            Form[] formArray = default;

            var list = new List<Form>(FormDefaultSet(fileArray));

            var array = list.ToArray();

            formArray = array;

            return formArray;
        }
    }
}
