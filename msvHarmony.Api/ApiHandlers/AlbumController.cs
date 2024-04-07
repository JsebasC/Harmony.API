using MediatR;
using Microsoft.AspNetCore.Mvc;
using msvHarmony.Application.Album;
using msvHarmony.Application.Canciones.Query;
using msvHarmony.Domain.Dtos;

namespace msvHarmony.Api.ApiHandlers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AlbumController : ControllerBase
    {

        readonly IMediator _mediator;

        public AlbumController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<List<AlbumDto>>> ListarAsync()
        {
            return Ok(await _mediator.Send(new AlbumQuery()));
        }
    }
}
