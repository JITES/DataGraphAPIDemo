using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace DataGrapiApi.Common
{
    [Serializable]
    public class CustomExceptions : Exception 
    {
        public CustomExceptions(string message, Exception ex) : base(message, ex)
        {

        }
        public CustomExceptions(string message) : base(message) 
        {

        }
        public CustomExceptions():base()
        {

        }

        protected CustomExceptions(SerializationInfo info, StreamingContext ctx) { }
    }
}
