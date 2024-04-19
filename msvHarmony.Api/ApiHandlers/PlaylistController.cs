using MediatR;
using Microsoft.AspNetCore.Mvc;
using msvHarmony.Application.Playlist.Command;
using msvHarmony.Application.Playlist.Command.Detalle;
using msvHarmony.Application.Playlist.Query;
using msvHarmony.Domain.Dto;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Api.ApiHandlers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlaylistController : ControllerBase
    {
        readonly IMediator _mediator;
        public PlaylistController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("listar/{usuarioId}")]
        public async Task<ActionResult<List<Playlist>>> ListarAsync(string usuarioId)
        {
            return Ok(await _mediator.Send(new ListarPlaylistQuery(usuarioId)));
        }

        [HttpPost("agregar")]
        public async Task<ActionResult> AgregarAsync([FromBody] AgregarPlaylistCommand request)
        {
            await _mediator.Send(request);

            return Ok();
        }

        [HttpPost("eliminar")]
        public async Task<ActionResult> EliminarAsync([FromBody] EliminarPlaylistCommand request)
        {
            await _mediator.Send(request);

            return Ok();
        }        

        [HttpGet("listar/detalle/{playlistId}")]
        public async Task<ActionResult<List<PlaylistDetalleDto>>> ListarDetalleAsync(string playlistId)
        {
            return Ok(await _mediator.Send(new ListarPlaylistDetalleQuery(playlistId)));
        }

        [HttpPost("agregar/detalle")]
        public async Task<ActionResult> AgregarDetalleAsync([FromBody] AgregarDetallePlaylistCommand request)
        {
            await _mediator.Send(request);

            return Ok();
        }

        [HttpPost("eliminar/detalle")]
        public async Task<ActionResult> EliminarDetalleAsync([FromBody] EliminarPlaylistDetalleCommand request)
        {
            await _mediator.Send(request);

            return Ok();
        }
    }
}
