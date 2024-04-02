using MediatR;
using Microsoft.AspNetCore.Mvc;
using msvHarmony.Application.Artista.Query;
using msvHarmony.Domain.Dtos;

namespace msvHarmony.Api.ApiHandlers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ArtistaController : ControllerBase
    {
        readonly IMediator _mediator;

        public ArtistaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<List<ArtistaDto>>> ListarAsync()
        {            
            return Ok(await _mediator.Send(new ArtistaSimpleQuery()));
        }
    }
}
