using StudentTasker.Data;
using StudentTaskerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTasker.Service.TaskService
{
    public interface IStudentTaskService
    {

        Task<List<DBA>> GetAllDbasAsync();
        Task<List<StudentTask>> GetAllStudentTasksAsync();
        Task<StudentTask> AddStudentTaskAsync(StudentTask studentTask);
        Task<DBA> AddStudentDbaAsync(DBA dba);
        Task<StudentTask> UpdateStudentRecordAsync(StudentTask StudentTask, int Id);
        Task<StudentTask> DeleteStudentRecordAsync(StudentTask studentTask, int id);
        Task<DBA> DeleteDbaRecordAsync(DBA dBA, int id);
        Task<DBA> UpdateDbaRecordAsync(DBA dBA, int id);
    }
}
