using Core;

namespace Core
{
    using System;
    internal partial class Form
    {
        internal static Int32 ForgeStreamPosition(Int32 startBounary, Int32 chunkSize, Int32 itemPosition, Int32 additive)
        {
            Int32 integerResult = default;

            var result = (startBounary + (chunkSize * ((itemPosition + additive) - 1)));

            integerResult = result;            
              
            return integerResult;
        }
    }
}
