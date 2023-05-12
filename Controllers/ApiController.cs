using Microsoft.AspNetCore.Mvc;
using Amazon.DynamoDBv2.DataModel;
using TodoApi.Models;
using AutoMapper;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly IDynamoDBContext _context;
        private readonly IMapper _mapper;

        public TodoItemsController(IDynamoDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostTodoItem(TodoItem todoItem)
        {
            var todoItemDynamo = _mapper.Map<TodoDynamo>(todoItem);
            await _context.SaveAsync(todoItemDynamo);

            return Created("", todoItem);
        }

        [HttpGet]
        public async Task<IActionResult> GetTodoItems()
        {
            var items = await _context.ScanAsync<TodoDynamo>(default).GetRemainingAsync();
            return Ok(items);
        }
    }
}
