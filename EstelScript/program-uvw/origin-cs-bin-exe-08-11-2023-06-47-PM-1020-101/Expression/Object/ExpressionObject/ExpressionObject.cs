using Core;

namespace Core
{
    using System;

    internal partial class Expression
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(Expression) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ExpressionObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ExpressionList) + ':' + ' ' + ". . ." + ' ' + $"<{ExpressionList.Count}>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ExpressionPointer) + ':' + ' ' + $"<{ExpressionPointer == null}>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ExpressionRootPointer) + ':' + ' ' + $"<{ExpressionRootPointer == null}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ExpressionObject) + ':',
                String.Empty + ExpressionObject,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ExpressionList) + ':',
                String.Empty + String.Join('\n'.ToString(), ExpressionList.ToArray()),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + ". . . . ." + ' ' + ':',
                String.Empty + RecurseTraverseView()
            });
        }
    }
}
