using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Expression
    {
        internal static IList<Expression> ExpressionFormSet(Form[] formArray)
        {
            ICollection<Expression> collectionResult = default;

            collectionResult = new Collection<Expression>();

            foreach (Form form in formArray)
            {
                var descriptor = true;

                descriptor = descriptor && (form.Data.Runtime.HeaderArray.Length >= 1) is true;

                if (descriptor is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                var expression = MakeExpressionRule();

                expression.Query("other");

                expression.Unlock("name");

                expression.Lock(form.Data.Runtime.HeaderArray[0]);

                expression.Release();

                expression.Query("execute");

                var l = ExpressionSentenceSetSurface(form.Data.Runtime.Content);

                Console.WriteLine($"test -> {l.Length}");

                foreach (String sentence in l)
                {
                    expression.Lock(sentence);

                    continue;
                }

                Console.WriteLine(expression);

                while (true) ;

                //expression.Unlock("xxx");

                collectionResult.Add(expression);

                continue;
            }

            return new List<Expression>(collectionResult);
        }
    }
}
