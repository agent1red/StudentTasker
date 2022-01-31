using StudentTasker.Data;
using StudentTaskerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTasker.Service.TaskService
{
    public class GetNewData : IGetNewData
    {

        private readonly NewDataContext _context;

        public GetNewData(NewDataContext context)
        {
            _context = context;
        }
        public List<DBA> GetAllDbas()
        {
            using (NewDataContext ctx = new NewDataContext())
            {
                var result = ctx.DBAs.ToList();
                return result;
            }
           
        }

        public List<StudentTask> GetAllStudentTasks()
        {

            using (NewDataContext ctx = new NewDataContext())
            {
                var result = ctx.StudentTasks.ToList();
                return result;
            }
         
        }

         
    }
}
