using MediatR;
using Microsoft.AspNetCore.Mvc;
using msvHarmony.Application.Favorito.Command;
using msvHarmony.Application.Favorito.Dto;
using msvHarmony.Application.Favorito.Query;

namespace msvHarmony.Api.ApiHandlers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FavoritoController : ControllerBase
    {
        readonly IMediator _mediator;
        public FavoritoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("listar/{usuarioId}")]
        public async Task<ActionResult<List<FavoritoDto>>> ListarAsync(string usuarioId)
        {
            return Ok(await _mediator.Send(new FavoritoQuery(usuarioId)));
        }

        [HttpPost("agregar")]
        public async Task<ActionResult> AgregarAsync([FromBody] AgregarFavoritoCommand request)
        {
            await _mediator.Send(request);

            return Ok();
        }

        [HttpPost("eliminar")]
        public async Task<ActionResult> EliminarAsync([FromBody] EliminarFavoritoCommand request)
        {
            await _mediator.Send(request);

            return Ok();
        }
    }
}
