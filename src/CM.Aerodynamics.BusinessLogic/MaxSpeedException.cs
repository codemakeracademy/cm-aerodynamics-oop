using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CM.Aerodynamics.BusinessLogic
{
    [Serializable]
    public class MaxSpeedException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public MaxSpeedException()
        {
        }

        public MaxSpeedException(string message) : base(message)
        {
        }

        public MaxSpeedException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MaxSpeedException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
