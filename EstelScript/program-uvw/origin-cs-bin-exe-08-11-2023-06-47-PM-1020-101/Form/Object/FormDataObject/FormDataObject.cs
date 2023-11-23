using Core;

namespace Core
{
    using System;

    internal partial struct FormData
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormData) + ' ' + '{',
                String.Empty + '.' + "data", 
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Measure) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Runtime) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(EndianFormat) + ':' + ' ' + EndianFormat,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(StringCodec) + ':' + ' ' + StringCodec,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ChunkSize) + ':' + ' ' + ChunkSize,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(StartBoundary) + ':' + ' ' + StartBoundary,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Measure) + ':', 
                String.Empty + Measure,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Runtime) + ':',
                String.Empty + Runtime
            });
        }
    }
}
