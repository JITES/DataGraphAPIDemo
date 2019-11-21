using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.BusinessLogic.Dashboard
{
    public class SampleFactoryMethod
    {
        public void SampleImplementation()
        {
            var salesService = new SalesTaskService();
            var productService = new ProductGrowthService();

            var taskReview = salesService.InitTask("SalesReview");
            var taskReject = salesService.InitTask("SalesReject");
            var taskApprove = salesService.InitTask("SalesApprove");

            var prtaskReview = productService.InitTask("ProductGrowthReview");
            var prtaskReject = productService.InitTask("ProductGrowthReject");
            var prtaskApprove = productService.InitTask("ProductGrowthApprove");

        }

    }
}
