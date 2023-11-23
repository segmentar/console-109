using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<String> ProgramDirectorySet(String directory)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var array = Directory.GetDirectories(directory);

            foreach (String childDirectory in array)
            {
                collectionResult.Add(childDirectory);

                var list = ProgramDirectorySet(childDirectory);

                foreach (var item_DIRECTORY in list)
                {
                    collectionResult.Add(item_DIRECTORY);

                    continue;
                }

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
