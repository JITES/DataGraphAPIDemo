using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.BusinessLogic.Dashboard
{
    public class ProductGrowthApproveTask : Task
    {
        public ProductGrowthApproveTask()
        {
            Name = "Product Growth";
            Type = "Product";
            Status = "In Progress";
        }

        public override void ExecuteAction()
        {
            // Pull data from thrid-party datasource
            // Verify and attach review notes
            // Process the task
            // Send email notification to users
        }
    }
}
