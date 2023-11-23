using Core;

namespace Core
{
    using System;

    internal partial class FormRuntime
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormData) + ' ' + '{',
                String.Empty + '.' + "data",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(NumberOfItemsInHeaderArray) + ':' + ' ' + NumberOfItemsInHeaderArray,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(HeaderArray) + ':' + ' ' + ". . ." + ' ' + $"<{HeaderArray.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Content) + ':' + ' ' + $"<safe><<{ContentSafe}>>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ExternalDebug) + ':' + ' ' + ExternalDebug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + "<safe>" + nameof(HeaderArray) + ':',
                String.Empty + String.Join('\n'.ToString(), HeaderArraySafe)
            });
        }
    }
}
