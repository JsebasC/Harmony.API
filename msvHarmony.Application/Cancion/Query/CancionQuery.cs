﻿using MediatR;
using msvHarmony.Domain.Dtos;

namespace msvHarmony.Application.Canciones.Query
{
    public record CancionQuery() : IRequest<List<CancionDto>>;
}
