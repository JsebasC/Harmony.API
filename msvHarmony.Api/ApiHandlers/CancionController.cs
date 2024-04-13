using MediatR;
using Microsoft.AspNetCore.Mvc;
using msvHarmony.Application.Canciones.Query;
using msvHarmony.Domain.Dto;

namespace msvHarmony.Api.ApiHandlers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CancionController : ControllerBase
    {

        readonly IMediator _mediator;

        public CancionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<List<CancionDto>>> ListarAsync()
        {
            return Ok(await _mediator.Send(new CancionQuery()));
        }
    }
}
