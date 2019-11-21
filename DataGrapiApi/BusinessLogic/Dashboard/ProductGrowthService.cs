using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.BusinessLogic.Dashboard
{
    public class ProductGrowthService : TaskFactory
    {
        protected override Task TaskService(string taskType)
        {
            Task _task = null;

            switch (taskType)
            {
                case "ProductGrowthReview":
                    _task = new ProductGrowthReviewTask();
                    break;
                case "ProductGrowthReject":
                    _task = new ProductGrowthRejectTask();
                    break;
                case "ProductGrowthApprove":
                    _task = new ProductGrowthApproveTask();
                    break;
            }

            return _task;
        }
    }
}
