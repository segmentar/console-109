using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Form
    {
        internal static IList<Form> FormDefaultSet(String[] fileArray)
        {
            ICollection<Form> collectionResult = default;

            collectionResult = new Collection<Form>();

            return new List<Form>(collectionResult);
        }
    }
}
