using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.BusinessLogic.Dashboard
{
    public abstract class Task
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public abstract void ExecuteAction();

        public void Process()
        {
            // Calls DB
        }
        public void UpdateStatus()
        {
            // update the status
        }

        public void SendEmail()
        {
            // Send email
        }

       


    }
}
