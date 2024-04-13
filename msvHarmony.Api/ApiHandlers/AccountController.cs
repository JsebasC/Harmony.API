using MediatR;
using Microsoft.AspNetCore.Mvc;
using msvHarmony.Application.Account.Command;
using msvHarmony.Application.Account.Query;
using msvHarmony.Application.Dto;

namespace msvHarmony.Api.ApiHandlers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AccountController : ControllerBase
    {
        readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("user/{uid}")]
        public async Task<ActionResult<UserDto>> UserByIdAsync(Guid uid)
        {            
            return Ok(await _mediator.Send(new AccountSimpleQuery(uid)));
        }

        [HttpPost("update")]
        public async Task<ActionResult> Update([FromForm] UpdateAccountCommand request)
        {
            await _mediator.Send(request);

            return Ok();
        }
    }
}
