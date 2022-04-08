using System;
using System.Collections.Generic;
using System.Linq;
using TodoList.Data.Models;
//using System.Threading.Tasks;
using TodoList.Data.ViewModels;

namespace TodoList.Data.Services
{
    public class TaskService
    {
        private AppDbContext _context;
        public TaskService(AppDbContext context)
        {
            _context = context;
        }
        public void AddTask(TaskVM task)
        {
            var _task = new Task()
            {
                taskName = task.taskName,
                Status = task.Status,
                date = DateTime.Now,
                Deleted = task.Deleted
            };
            _context.Tasks.Add(_task);
            _context.SaveChanges();
        }

        public List<Task> GetAllTasks() => _context.Tasks.ToList();

        public Task GetTaskById(Guid taskId) => _context.Tasks.FirstOrDefault(n => n.Id == taskId);

        public Task UpdateTaskById(Guid taskId, TaskVM task)
        {
            var _task = _context.Tasks.FirstOrDefault(n => n.Id == taskId);
            if(_task != null)
            {
                _task.taskName = task.taskName;
                _task.Status = task.Status;
                _task.date = DateTime.Now;
                _task.Deleted = task.Deleted;

                _context.SaveChanges();
            }
            return _task;
        }
        public void DeleteTaskById(Guid taskId)
        {
            var _task = _context.Tasks.FirstOrDefault(n => n.Id == taskId);
            if(_task != null)
            {
                _context.Tasks.Remove(_task);
                _context.SaveChanges();
            }
        }
    }
}
