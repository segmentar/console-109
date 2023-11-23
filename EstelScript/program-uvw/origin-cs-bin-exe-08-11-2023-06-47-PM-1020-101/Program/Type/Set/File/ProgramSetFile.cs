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
        internal static IList<String> ProgramFileSet(String[] directoryArray)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            if (Architecture.FormFileExtension is null)
            {
                goto skip;
            }
            else
                "false".ToString();

            foreach (String directory in directoryArray)
            {
                var array = Directory.GetFiles(directory);

                foreach (String file in array)
                {
                    var left = Path.GetExtension(file).TrimStart('.');

                    var right = Architecture.FormFileExtension.TrimStart('.');

                    if ((left == right) is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    collectionResult.Add(file);

                    continue;
                }

                continue;
            }

        skip:
            {
                return new List<String>(collectionResult);
            }
        }
    }
}
