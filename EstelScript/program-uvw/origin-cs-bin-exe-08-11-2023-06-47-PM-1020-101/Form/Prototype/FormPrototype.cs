using Core;

namespace Core
{
    using System;

    internal partial class Form
    {
        internal Form(FormData data)
        {
            data.Runtime = new FormRuntime();

            FormRuntime.NumberOfItemsInHeaderArrayRuntime(data);

            FormRuntime.HeaderArrayRuntime(data);

            FormRuntime.HeaderArrayRuntimeSafe(data);

            FormRuntime.ContentRuntime(data);

            FormRuntime.ContentRuntimeSafe(data);

            FormRuntime.ExternalDebugRuntime(data);

            this.Data = data;

            return;
        }

        internal Form(FormMeasure measure, Boolean endianFormat, Int32 stringCodec, Int32 chunkSize, Int32 startBoundary, Boolean debug)
        {
            FormData data;

            data = new FormData();

            data.Measure = measure;

            data.EndianFormat = endianFormat;

            data.StringCodec = stringCodec;

            data.ChunkSize = chunkSize;

            data.StartBoundary = startBoundary;

            if (debug is true)
            {
                data.IsDebug = true;
            }
            else
                "false".ToString();

            Form form;

            form = new Form(data);

            this.Data = form.Data;

            return;
        }
    }
}
