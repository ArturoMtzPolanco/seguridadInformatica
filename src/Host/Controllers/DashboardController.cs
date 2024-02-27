using ApplicationCore.Commands.LogsR;
using ApplicationCore.Commands.Users;
using ApplicationCore.Interfaces;
using ApplicationCore.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace Host.Controllers
{
    [Route("api/dashboard")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _service;
        private readonly IMediator _mediator;
        public DashboardController(IDashboardService service, IMediator mediator)
        {
            _service = service;
            _mediator = mediator;
        }

        [Route("getData")]
        [HttpGet]
      
        public async Task<IActionResult> GetUsuarios()
        {
            var result = await _service.GetData();
            return Ok(result);
        }


        [HttpPost("create")]
        public async Task<ActionResult<Response<int>>> Create (CreateLogsCommand request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }


        [HttpGet("ipGet")]
        public async Task<IActionResult> GetIp()
        {
            var result = await (_service.GetIp());
            return Ok(result);
        }

         [HttpPost("createlog")]
        public async Task<ActionResult<Response<int>>> Createlog (CreateLogsCommand request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }


    }
}
