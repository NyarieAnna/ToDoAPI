using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Data.Services;
using TodoList.Data.ViewModels;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        public TaskService _taskService;
        public TasksController(TaskService taskService)
        {
            _taskService = taskService;
        }
        [HttpGet("get-allTasks")]
        public IActionResult GetAllTasks()
        {
            var allTasks = _taskService.GetAllTasks();
            return Ok(allTasks);
        }
        [HttpGet("get-TaskById /{Id}")]
        public IActionResult GetTaskById(Guid Id)
        {
            var task = _taskService.GetTaskById(Id);
            return Ok(task);
        }


        [HttpPost("add-task")]
        public IActionResult AddTask([FromBody]TaskVM task)
        {
            _taskService.AddTask(task);
            return Ok();
        }
        [HttpPut("Update TaskById/{Id}")]
        public IActionResult UpdateTaskById(Guid Id, [FromBody] TaskVM task)
        {
            var updatedTask = _taskService.UpdateTaskById(Id, task);
            return Ok(updatedTask);
        }
        [HttpDelete("Delete TaskById/{Id}")]
        public IActionResult DeleteTaskById(Guid Id)
        {
            _taskService.DeleteTaskById(Id);
            return Ok();
        }

    }
}
