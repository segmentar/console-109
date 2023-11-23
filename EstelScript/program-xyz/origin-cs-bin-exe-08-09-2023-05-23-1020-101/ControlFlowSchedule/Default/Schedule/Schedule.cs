using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Schedule
    {
        internal List<Form> FormList;

        internal Schedule(List<Form> formList)
        {
            this.FormList = formList;

            return;
        }

        ~Schedule()
        {
            return;
        }
    }
}
