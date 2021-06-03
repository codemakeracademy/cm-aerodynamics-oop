using System;
using System.Runtime.Serialization;

namespace CM.Aerodynamics.BusinessLogic
{
    [Serializable]
    public class SpeedIsToSmallException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public SpeedIsToSmallException()
        {
        }

        public SpeedIsToSmallException(string message) : base(message)
        {
        }

        public SpeedIsToSmallException(string message, Exception inner) : base(message, inner)
        {
        }

        protected SpeedIsToSmallException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}