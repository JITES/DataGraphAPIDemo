using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.Common.DataLayerExceptions
{
    public class DataLayerException:Exception
    {
        public DataLayerException(string message, Exception ex) : base(message, ex)
        {
            // Log to specific place
        }
        public DataLayerException(string message) : base(message)
        {

        }
        public DataLayerException() : base()
        {

        }
    }
}
