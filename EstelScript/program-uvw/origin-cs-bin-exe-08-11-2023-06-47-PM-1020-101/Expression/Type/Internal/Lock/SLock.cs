﻿using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        internal void SLock(String value)
        {
            SpaceExpression.Lock(value);

            return;
        }
    }
}
