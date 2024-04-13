using MediatR;

namespace msvHarmony.Application.Favorito.Command
{
    public record AgregarFavoritoCommand(string UsuarioId, string CancionId) : IRequest;
}
