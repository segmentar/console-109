using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Form
    {
        internal static IList<Form> ReadFromFileSet(String[] fileArray)
        {
            ICollection<Form> collectionResult = default;

            collectionResult = new Collection<Form>();

            foreach (String file in fileArray)
            {
                var form = ForgeReadFromFile(file);

                collectionResult.Add(form);

                continue;
            }

            return new List<Form>(collectionResult);
        }
    }
}
