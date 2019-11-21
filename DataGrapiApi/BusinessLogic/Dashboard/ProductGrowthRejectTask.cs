using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.BusinessLogic.Dashboard
{
    public class ProductGrowthRejectTask : Task
    {
        public ProductGrowthRejectTask()
        {
            Name = "Product Growth";
            Type = "Product";
            Status = "In Progress";
        }

        public override void ExecuteAction()
        {
            // Pull data from thrid-party datasource
            // Verify and attach Rejection notes
            // Send email notification to requester
        }
    }
}
