using Microsoft.EntityFrameworkCore;
using StudentTasker.Data;
using StudentTaskerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StudentTasker.Service.TaskService
{
    public class StudentTaskService : IStudentTaskService
    {
        //private readonly DataContext _context;
        private readonly IDbContextFactory<DataContext> _context;

        public StudentTaskService(IDbContextFactory<DataContext> context)
        {
            _context = context;
        }


        public async Task<List<DBA>> GetAllDbasAsync()
        {
            using (var ctx = _context.CreateDbContext())
            {
                return await ctx.DBAs.OrderByDescending(x => x.DateAdded).ToListAsync();
            }
         
            
        }

        public async Task<List<StudentTask>> GetAllStudentTasksAsync()
        {
            using (var ctx = _context.CreateDbContext())
            {
                var result = await ctx.StudentTasks.OrderByDescending(x => x.DateCreated).ToListAsync();

                return result;
            }
          
        }

        public async Task<StudentTask> AddStudentTaskAsync(StudentTask studentTask)
        {
            using (var ctx = _context.CreateDbContext())
            {
                await ctx.StudentTasks.AddAsync(studentTask);
                await ctx.SaveChangesAsync();
                return studentTask;
            }
          
        }

        public async Task<DBA> AddStudentDbaAsync(DBA dba)
        {
            using (var ctx = _context.CreateDbContext())
            {
                await ctx.DBAs.AddAsync(dba);
                await ctx.SaveChangesAsync();
                return dba;
            }
          
        }

        public async Task<StudentTask> UpdateStudentRecordAsync(StudentTask studentTask, int Id)
        {
            using (var ctx = _context.CreateDbContext())
            {
                var result = studentTask;
                if (result == null)
                {
                    return null;
                }

                ctx.Update(result);
                await ctx.SaveChangesAsync();
                return studentTask;
            }

            
        }

        public async Task<DBA> UpdateDbaRecordAsync(DBA dBA, int Id)
        {
            using (var ctx = _context.CreateDbContext())
            {
                var result = dBA;
                if (result == null)
                {
                    return null;
                }
                ctx.Update(result);
                await ctx.SaveChangesAsync();
                return dBA;
            }
            
        }

        public async Task<StudentTask> DeleteStudentRecordAsync(StudentTask studentTask, int id)
        {

            using (var ctx = _context.CreateDbContext())
            {
                var result = await ctx.StudentTasks.SingleOrDefaultAsync(x => x.TaskId == studentTask.TaskId);
                if (result == null)
                {
                    return null;
                }
                ctx.StudentTasks.Remove(result);
                await ctx.SaveChangesAsync();
                return result;
            }
            
        }

        public async Task<DBA> DeleteDbaRecordAsync(DBA dBA, int id)
        {

            using (var ctx = _context.CreateDbContext())
            {
                var result = await ctx.DBAs.SingleOrDefaultAsync(x => x.DbaId == dBA.DbaId);
                if (result == null)
                {
                    return null;
                }
                ctx.DBAs.Remove(result);
                await ctx.SaveChangesAsync();
                return result;
            }
           
        }
    }
}
