using Core;

namespace Core
{
    using System;

    internal partial class FormRuntime
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormRuntime) + ' ' + '{',
                String.Empty + '.' + "runtime",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(HeaderArray) + ':' + ' ' + ". . ." + ' ' + $"<{HeaderArray.Length}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Content) + ':' + ' ' + $"<safe><<{ContentSafe}>>",
                String.Empty + '}',
                String.Empty,
                String.Empty + "<safe>" + ' ' + nameof(HeaderArray) + ':',
                String.Empty + String.Join('\n'.ToString(), HeaderArraySafe)
            });
        }
    }
}
