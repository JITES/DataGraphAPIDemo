using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.BusinessLogic.Dashboard
{
    public class SalesTaskService : TaskFactory
    {
        protected override Task TaskService(string taskType)
        {
            Task _task = null;

            switch (taskType)
            {
                case "SalesReview":
                    _task = new SalesReviewTask();
                    break;
                case "SalesReject":
                    _task = new SalesRejectTask();
                    break;
                case "SalesApprove":
                    _task = new SalesApproveTask();
                    break;
            }

            return _task;
        }
    }
}
