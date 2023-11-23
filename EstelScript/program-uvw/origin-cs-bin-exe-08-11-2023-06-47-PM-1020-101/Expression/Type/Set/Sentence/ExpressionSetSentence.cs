using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Expression
    {
        internal static IList<String> ExpressionSentenceSet(String content)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var split = content.Split(new String[] { "\r\n" }, StringSplitOptions.None);

            foreach (String stringItem in split)
            {
                var trim = stringItem.TrimEnd('.');

                if ((stringItem.Length == trim.Length) is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                collectionResult.Add(stringItem);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
