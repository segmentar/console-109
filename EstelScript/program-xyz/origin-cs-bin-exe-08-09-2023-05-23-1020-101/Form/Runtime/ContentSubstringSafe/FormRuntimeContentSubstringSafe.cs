using Core;

namespace Core
{
    using System;

    internal partial class FormRuntime
    {
        internal static void ContentSubstringSafe(FormData data)
        {
            var array = data.Runtime.Content.ToCharArray();

            var indexer = -1;

            foreach (Char character in data.Runtime.Content)
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
            }

            var result = new String(array);

            data.Runtime.ContentSafe = result;

            return;
        }
    }
}
