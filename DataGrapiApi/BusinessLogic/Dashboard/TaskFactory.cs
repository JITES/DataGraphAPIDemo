using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.BusinessLogic.Dashboard
{
    public abstract class TaskFactory
    {
        public Task InitTask(string taskType)
        {
            var _task = TaskService(taskType);

            _task.ExecuteAction();
            _task.Process();
            _task.UpdateStatus();
            _task.SendEmail();

            return _task;
        }
        protected abstract Task TaskService(string type);
    }
}
