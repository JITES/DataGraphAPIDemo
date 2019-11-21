using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.BusinessLogic.Dashboard
{
    public class SalesReviewTask : Task
    {
        public SalesReviewTask()
        {
            Name = "Sales Review";
            Type = "Finance";
            Status = "In Progress";
        }
        public override void ExecuteAction()
        {
            // Update the status in Database
            // Process the task
            // Send email notification to users
        }
    }
}
