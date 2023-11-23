using Core;

namespace Core
{
    using System;

    internal partial class Control
    {
        internal String Filename;

        internal String Content;

        internal Control(String filename, String content)
        {
            this.Filename = filename;

            this.Content = content;

            return;
        }

        ~Control()
        {
            return;
        }
    }
}
