namespace msvHarmony.Domain.Dto
{
    public class PlaylistDetalleDto
    {
        public string Id { get; set; }
        public string PlaylistId { get; set; }
        public CancionDto Cancion { get; set; }
    }
}
