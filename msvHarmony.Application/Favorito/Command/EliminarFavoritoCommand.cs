using MediatR;

namespace msvHarmony.Application.Favorito.Command
{
    public record EliminarFavoritoCommand(string FavoritoId, string UsuarioId) : IRequest;
}
