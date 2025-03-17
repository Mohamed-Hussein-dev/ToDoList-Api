using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ToDo.Application.Tasks.Commands.CheckTask;
using ToDo.Application.Tasks.Commands.CreateTask;
using ToDo.Application.Tasks.Commands.DeleteTask;
using ToDo.Application.Tasks.Commands.UpdateTask;
using ToDo.Application.Tasks.Queries.GetTask;
using ToDo.Application.Tasks.Queries.GetAllTasks;
using ToDo.Contract.Tasks.CreateTask;
using ToDo.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.AspNetCore.Authorization;

namespace ToDo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TaskController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("CreateTask")]
        public async Task<IActionResult> CreateTask(CreateTaskRequestDto request)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var command = new CreateTaskCommand(request.TaskTitile, request.TaskDescription, request.DueDate , userId);
            var result = await _mediator.Send(command);

            if (result.IsError)
            {
                var error = result.FirstError;
                return BadRequest(new { error = error.Description });
            }

            return CreatedAtAction(nameof(CreateTask), new { id = result.Value });
        }

        [HttpDelete("{TaskId}")]
        public async Task<IActionResult> DeleteTask(int TaskId)
        {
            var command = new DeleteTaskCommand(TaskId);
            var result = await _mediator.Send(command);

            if (result.IsError)
            {
                var error = result.FirstError;
                return NotFound(new { error = error.Description });
            }

            return NoContent();
        }

        [HttpGet("{TaskId}")]
        public async Task<IActionResult> GetTask(int TaskId) {
            var command = new GetTaskCommand(TaskId);
            var result = await _mediator.Send(command);

            if (result.IsError)
            {
                var error = result.FirstError;
                return NotFound(new { error = error.Description });
            }
            return Ok(result.Value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTask(TaskItem task)
        {
            var command = new UpdateTaskCommand(task);

            var result = await _mediator.Send(command);

            if (result.IsError)
            {
                var error = result.FirstError;
                return NotFound(new { error = error.Description });
            }

            return Ok(task);
        }

        [HttpPut("check/{taskId}")]
        public async Task<IActionResult> CheckTask(int taskId)
        {
            var command = new CheckTaskCommand(taskId);

            var result = await _mediator.Send(command);

            if (result.IsError)
            {
                var error = result.FirstError;
                return NotFound(new { error = error.Description });
            }
            
            return Ok("done");
               
        }

        [HttpGet("GetAllTasks")]
        public async Task<IActionResult> GetAllTasks()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var command = new GetAllTasksCommand(userId);
            var Tasks = await _mediator.Send(command);

            return Tasks.Match(
                success => Ok(Tasks.Value),
                errors => Problem(Tasks.FirstError.Description));
        }
    }
}
