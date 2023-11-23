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

            foreach (String directoryDirectory in Directory.GetDirectories(directory))
            {
                collectionResult.Add(directoryDirectory);

                foreach (String directoryDirectoryDirectory in Directory.GetDirectories(directoryDirectory))
                {
                    collectionResult.Add(directoryDirectoryDirectory);

                    continue;
                }

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
