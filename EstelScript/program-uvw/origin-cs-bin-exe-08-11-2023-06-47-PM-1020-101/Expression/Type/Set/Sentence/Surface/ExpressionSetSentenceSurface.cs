using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Expression
    {
        internal static String[] ExpressionSentenceSetSurface(String content)
        {
            String[] stringArray = default;

            var list = new List<String>(ExpressionSentenceSet(content));

            var array = list.ToArray();

            stringArray = array;

            return stringArray;
        }
    }
}
