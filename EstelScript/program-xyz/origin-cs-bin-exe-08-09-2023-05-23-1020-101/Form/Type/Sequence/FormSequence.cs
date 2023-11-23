using Core;

namespace Core
{
    using System;

    internal partial class FormSequence
    {
        internal Form Result { get; set; } = default;

        internal FormSequence(ControlFlowSchedule controlFlowSchedule, Boolean debug)
        {
            Debug(controlFlowSchedule, debug);

            Int32[] positionArray = new Int32[2];

            positionArray[0] = controlFlowSchedule.Control.Content.IndexOf(',', controlFlowSchedule.Flow.Position);

            positionArray[1] = controlFlowSchedule.Control.Content.IndexOf(".....", controlFlowSchedule.Flow.Position);

            var descriptor = true;

            descriptor = descriptor && (positionArray[0] == -1) is false;

            descriptor = descriptor && (positionArray[1] == -1) is false;

            descriptor = descriptor && (positionArray[0] < positionArray[1]) is true;

            descriptor = descriptor && (positionArray[1] > positionArray[0]) is true;

            descriptor = descriptor && (controlFlowSchedule.Flow.Position < positionArray[0]) is true;

            descriptor = descriptor && (controlFlowSchedule.Flow.Position < positionArray[1]) is true;

            if (descriptor is false)
            {
                return;
            }
            else
                "false".ToString();

            var form = new Form(controlFlowSchedule, positionArray, debug);

            this.Result = form;

            return;
        }

        ~FormSequence()
        {
            return;
        }
    }
}
