using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Infrastructure.DataSource.ModelConfig
{
    public class ColaboracionConfig : IEntityTypeConfiguration<Colaboracion>
    {
        public void Configure(EntityTypeBuilder<Colaboracion> builder)
        {
            builder.ToTable("Colaboracion");

            builder.HasOne(d => d.Cancion).WithMany(p => p.Colaboracions)
                .HasForeignKey(d => d.CancionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Colaboracion_Cancion");

            builder.HasData(            
                new Colaboracion
                {
                    Id = Guid.Parse("1108f4ae-0bd1-46e3-a3d0-78f488ebd0e0"),
                    CancionId = Guid.Parse("d2f3c9a1-46e5-40d6-b782-674ba61334c8"),
                    ArtistaId = Guid.Parse("b2d8a25a-01b3-454a-bb62-c829cff931b7"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Colaboracion
                {
                    Id = Guid.Parse("05775810-99c0-4c9f-9c64-67b62a757009"),
                    CancionId = Guid.Parse("dbf159ea-55f1-44f5-a98e-36d45b62bc28"),
                    ArtistaId = Guid.Parse("00da8580-99e6-4e16-8a0b-d8739b4f98ff"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },                              
                new Colaboracion
                {
                    Id = Guid.Parse("5601e689-455c-492d-8ec5-55b950101d56"),
                    CancionId = Guid.Parse("090e58d6-0f99-471d-a614-9401882fadcb"),
                    ArtistaId = Guid.Parse("00da8580-99e6-4e16-8a0b-d8739b4f98ff"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },              
                new Colaboracion
                {
                    Id = Guid.Parse("cfc16fef-a973-4748-b5ac-ca2cdfd2bf0b"),
                    CancionId = Guid.Parse("59bcaa11-7849-41e1-8e50-beb241e1d612"),
                    ArtistaId = Guid.Parse("00da8580-99e6-4e16-8a0b-d8739b4f98ff"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Colaboracion
                {
                    Id = Guid.Parse("bae3e15f-dcd3-439a-bd36-332c4a6841cc"),
                    CancionId = Guid.Parse("59bcaa11-7849-41e1-8e50-beb241e1d612"),
                    ArtistaId = Guid.Parse("286f574b-b842-4930-86c1-b873350a0d98"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Colaboracion
                {
                    Id = Guid.Parse("c7c25b3f-0cad-4e5a-a096-be6534aead82"),
                    CancionId = Guid.Parse("30eb8630-4ab5-4a04-a9f8-ed6eeb622da7"),
                    ArtistaId = Guid.Parse("c24fb9db-848c-4a9d-8ae0-44a97a38f0cb"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                }
            );
        }
    }
}
