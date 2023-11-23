using Core;

namespace Core
{
    using System;

    using System.Text;

    using System.Collections;

    internal partial class Expression
    {
        internal Byte[] GetBytes()
        {
            Byte[] arrayResult = default;

            arrayResult = GetBytesDepth(0, this);

            return arrayResult;
        }

        internal Byte[] GetBytesDepth(Int32 layer, Expression expression)
        {
            Byte[] arrayResult = default;

            layer = layer + 1;

            var list = new ArrayList();

            var ordinal = 1;

            foreach (Expression expressionChild in expression.ExpressionList)
            {
                var tuple = new Tuple<Int32, Int32, String>(layer, ordinal, expressionChild.ExpressionObject.ToString());

                var array_LAYER = BitConverter.GetBytes(tuple.Item1);

                var array_POSITION = BitConverter.GetBytes(tuple.Item2);

                var array_STRING = Encoding.Default.GetBytes(tuple.Item3);

                foreach (Byte byteItem in array_LAYER)
                {
                    list.Add(byteItem);

                    continue;
                }

                foreach (Byte byteItem in array_POSITION)
                {
                    list.Add(byteItem);

                    continue;
                }

                foreach (Byte byteItem in array_STRING)
                {
                    list.Add(byteItem);

                    continue;
                }

                var array = GetBytesDepth(layer, expressionChild);

                foreach (Byte byteItem in array)
                {
                    list.Add(byteItem);

                    continue;
                }

                ordinal = ordinal + 1;

                continue;
            }

            var reflect = (Byte[])(list.ToArray(typeof(Byte)) as Array);

            arrayResult = reflect;

            return arrayResult;
        }
    }
}
