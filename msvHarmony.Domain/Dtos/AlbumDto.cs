namespace msvHarmony.Domain.Dtos
{
    public class AlbumDto
    {
        public string Id { get; set; } = string.Empty;
        public string Portada { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public int Anio { get; set; }
        public string Genero { get; set; } = string.Empty;
        public string Artista { get; set; } = string.Empty;
        public string Discografica { get; set; } = string.Empty;
        public List<CancionDto> Canciones { get; set; }
    }
}
