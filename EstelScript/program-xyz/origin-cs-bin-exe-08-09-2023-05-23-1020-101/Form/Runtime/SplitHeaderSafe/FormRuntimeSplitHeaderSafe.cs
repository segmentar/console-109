using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class FormRuntime
    {
        internal static void SplitHeaderSafe(FormData data)
        {
            var list = new ArrayList();

            foreach (String stringItem in data.Runtime.HeaderArray)
            {
                var array = stringItem.ToCharArray();

                var indexer = -1;

                foreach (Char character in stringItem)
                {
                    indexer = indexer + 1;

                    if (Char.IsControl(character) is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var whitespace = Convert.ToChar(32);

                    array[indexer] = whitespace;

                    continue;
                }

                var result = new String(array);

                list.Add(result);

                continue;
            }

            var reflect = (String[])(list.ToArray(typeof(String)) as Array);

            data.Runtime.HeaderArraySafe = reflect;

            return;
        }
    }
}
