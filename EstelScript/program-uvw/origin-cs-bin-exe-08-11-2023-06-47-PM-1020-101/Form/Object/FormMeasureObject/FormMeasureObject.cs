using Core;

namespace Core
{
    using System;

    internal partial class FormMeasure
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormMeasure) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(FileStream) + ':' + ' ' + ". . .", 
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(MemoryStream) + ':' + ' ' + ". . .",  
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(BinaryReader) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FileStream) + ':', 
                String.Empty + FileStream,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(MemoryStream) + ':',
                String.Empty + MemoryStream,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(BinaryReader) + ':',
                String.Empty + BinaryReader
            });
        }
    }
}
