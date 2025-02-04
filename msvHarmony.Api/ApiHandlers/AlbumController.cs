﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using msvHarmony.Application.Album.Query;
using msvHarmony.Domain.Dto;

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
