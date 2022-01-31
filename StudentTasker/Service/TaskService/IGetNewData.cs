using StudentTaskerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTasker.Service.TaskService
{
    public interface IGetNewData
    {
        List<DBA> GetAllDbas();
        List<StudentTask> GetAllStudentTasks();
    }
}
