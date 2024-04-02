using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace msvHarmony.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artista",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discografica",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discografica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlist",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Anio = table.Column<int>(type: "int", unicode: false, nullable: false),
                    Portada = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ArtistaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GeneroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscograficaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Album_Artista",
                        column: x => x.ArtistaId,
                        principalTable: "Artista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Album_Discografica",
                        column: x => x.DiscograficaId,
                        principalTable: "Discografica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Album_Genero",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cancion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    Portada = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlbumId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cancion_Album",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Colaboracion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArtistaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboracion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaboracion_Cancion",
                        column: x => x.CancionId,
                        principalTable: "Cancion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Favorito",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CancionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorito_Cancion",
                        column: x => x.CancionId,
                        principalTable: "Cancion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlaylistDetalle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaylistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaylistDetalle_Cancion",
                        column: x => x.CancionId,
                        principalTable: "Cancion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlaylistDetalle_Playlist",
                        column: x => x.PlaylistId,
                        principalTable: "Playlist",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Artista",
                columns: new[] { "Id", "CreatedOn", "LastModifiedOn", "Nombre" },
                values: new object[,]
                {
                    { new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7269), "Bad Bunny" },
                    { new Guid("286f574b-b842-4930-86c1-b873350a0d98"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7264), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7265), "J Balvin" },
                    { new Guid("41f40298-2bce-45b5-9cf0-6017b2b12f33"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7258), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7259), "Shakira" },
                    { new Guid("740d3805-1377-4e3e-962f-16b594401624"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7273), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7274), "Daddy Yankee" },
                    { new Guid("839d6647-abb1-4b26-b096-626be91e8fa9"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7278), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7279), "Carlos Santana" },
                    { new Guid("96303db8-663d-441f-b85b-f2424dc42f4c"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7233), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7242), "Beyoncé" },
                    { new Guid("b2d8a25a-01b3-454a-bb62-c829cff931b7"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7247), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7249), "Michael Jackson" },
                    { new Guid("c24fb9db-848c-4a9d-8ae0-44a97a38f0cb"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7253), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(7254), "Bob Marley" }
                });

            migrationBuilder.InsertData(
                table: "Discografica",
                columns: new[] { "Id", "CreatedOn", "LastModifiedOn", "Nombre" },
                values: new object[,]
                {
                    { new Guid("315721f0-9942-4ca2-a7cb-af423dac1d20"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(5366), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(5367), "EMI Music" },
                    { new Guid("34a47160-6312-4f1f-a220-4608acb7daac"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(5361), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(5362), "Warner Music Group" },
                    { new Guid("71f1d39b-5fbd-42d7-b4df-a904880b904d"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(5356), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(5357), "Universal Music Group" },
                    { new Guid("7e49603a-44e5-48d3-990c-691008b0e88a"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(5351), "Sony Music Entertainment" }
                });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "CreatedOn", "LastModifiedOn", "Nombre" },
                values: new object[,]
                {
                    { new Guid("005ec1d9-e027-4000-bf14-007b1dd5a1a4"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6247), "Hip-Hop/Rap" },
                    { new Guid("0a2cee36-6643-43b3-b0a3-ae29aa36ebb6"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6261), "Reggae" },
                    { new Guid("1fe91b74-2e0a-44aa-9229-8c12d985eda9"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6266), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6267), "Country" },
                    { new Guid("4eb68ff4-7b9c-4618-b64b-a91f51c4bb25"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6276), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6277), "Folk" },
                    { new Guid("541dfa54-35fc-4a70-8aae-cb7b88912945"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6290), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6291), "Metal" },
                    { new Guid("8eecad94-b361-45fa-80e5-e11a424f9388"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6271), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6272), "Electronic/Dance" },
                    { new Guid("8fed34da-dbe0-4ffb-b7e4-59b1546d446e"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6242), "Rock" },
                    { new Guid("b0b3b676-2509-4557-93f3-91d5c134f404"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6252), "R&B/Soul" },
                    { new Guid("b2a94699-9ff0-4e2c-a867-4e915aa86d3a"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6255), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6256), "Jazz" },
                    { new Guid("baa5cc89-28d4-4ce0-8210-24b1ec453fdf"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6282), "Blues" },
                    { new Guid("c0fa37f3-5fb3-41d2-ba70-05fcbd352218"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6299), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6300), "Reggaetón" },
                    { new Guid("cdc4a9d0-9618-413c-b8ef-3c75b2f87aa4"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6235), "Pop" },
                    { new Guid("d9df4cc3-7d0d-45ce-959b-7fb34aac6d58"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6285), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6286), "Indie" },
                    { new Guid("ecb3ea6f-e1db-497a-b777-b58bf7f4f77f"), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6295), new DateTime(2024, 4, 2, 15, 33, 8, 774, DateTimeKind.Local).AddTicks(6296), "Funk" }
                });

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "Anio", "ArtistaId", "CreatedOn", "DiscograficaId", "GeneroId", "LastModifiedOn", "Portada", "Titulo" },
                values: new object[,]
                {
                    { new Guid("09f84863-c6bd-4d04-a076-a145847496c8"), 2019, new Guid("286f574b-b842-4930-86c1-b873350a0d98"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(1773), new Guid("7e49603a-44e5-48d3-990c-691008b0e88a"), new Guid("c0fa37f3-5fb3-41d2-ba70-05fcbd352218"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(1774), "Oasis.jpg", "Oasis" },
                    { new Guid("36f0c39c-006c-4ba9-b9f1-93a0cb9c2695"), 2018, new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(1782), new Guid("7e49603a-44e5-48d3-990c-691008b0e88a"), new Guid("c0fa37f3-5fb3-41d2-ba70-05fcbd352218"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(1783), "PorSiempre.jpg", "X 100pre" },
                    { new Guid("a9cbd226-1b7b-4efe-b5d1-b2951bf16d39"), 2020, new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(1764), new Guid("7e49603a-44e5-48d3-990c-691008b0e88a"), new Guid("c0fa37f3-5fb3-41d2-ba70-05fcbd352218"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(1765), "UltimoTour.jpg", "El Último Tour del Mundo" },
                    { new Guid("dddf3f3e-c737-4d93-81bf-2a15354ceee7"), 1982, new Guid("b2d8a25a-01b3-454a-bb62-c829cff931b7"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(1737), new Guid("7e49603a-44e5-48d3-990c-691008b0e88a"), new Guid("8fed34da-dbe0-4ffb-b7e4-59b1546d446e"), new DateTime(2024, 4, 2, 15, 33, 8, 771, DateTimeKind.Local).AddTicks(1754), "Thriller.jpg", "Thriller" }
                });

            migrationBuilder.InsertData(
                table: "Cancion",
                columns: new[] { "Id", "AlbumId", "CreatedOn", "Duracion", "LastModifiedOn", "Nombre", "Portada" },
                values: new object[,]
                {
                    { new Guid("090e58d6-0f99-471d-a614-9401882fadcb"), new Guid("36f0c39c-006c-4ba9-b9f1-93a0cb9c2695"), new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4502), 207, new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4504), "Ni Bien Ni Mal", "NiBienMal.jpg" },
                    { new Guid("32b45778-764a-4ae0-9a44-5555d189d6a9"), new Guid("dddf3f3e-c737-4d93-81bf-2a15354ceee7"), new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4438), 283, new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4446), "Wanna Be Startin' Somethin'", "Wanna.jpg" },
                    { new Guid("34645ff8-7bd8-42d6-9749-1beae05ff7ad"), new Guid("a9cbd226-1b7b-4efe-b5d1-b2951bf16d39"), new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4475), 219, new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4477), "Hoy Cobré", "HoyCobre.jpg" },
                    { new Guid("59bcaa11-7849-41e1-8e50-beb241e1d612"), new Guid("09f84863-c6bd-4d04-a076-a145847496c8"), new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4492), 263, new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4494), "La Canción", "LaCancion.jpg" },
                    { new Guid("9cf403ae-6c10-47aa-95ca-5dc3403ec2da"), new Guid("09f84863-c6bd-4d04-a076-a145847496c8"), new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4484), 246, new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4485), "Qué Pretendes", "Pretendes.jpg" },
                    { new Guid("d2f3c9a1-46e5-40d6-b782-674ba61334c8"), new Guid("dddf3f3e-c737-4d93-81bf-2a15354ceee7"), new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4456), 357, new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4458), "Thriller", "Thriller-Cancion.jpg" },
                    { new Guid("d7584f4f-5b7e-4102-886c-20a59cd22752"), new Guid("36f0c39c-006c-4ba9-b9f1-93a0cb9c2695"), new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4512), 214, new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4513), "Caro", "Caro.jpg" },
                    { new Guid("dbf159ea-55f1-44f5-a98e-36d45b62bc28"), new Guid("a9cbd226-1b7b-4efe-b5d1-b2951bf16d39"), new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4466), 210, new DateTime(2024, 4, 2, 15, 33, 8, 772, DateTimeKind.Local).AddTicks(4468), "Te Mudaste", "TeMudaste.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Colaboracion",
                columns: new[] { "Id", "ArtistaId", "CancionId", "CreatedOn", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("05775810-99c0-4c9f-9c64-67b62a757009"), new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"), new Guid("dbf159ea-55f1-44f5-a98e-36d45b62bc28"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1175), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1176) },
                    { new Guid("1108f4ae-0bd1-46e3-a3d0-78f488ebd0e0"), new Guid("b2d8a25a-01b3-454a-bb62-c829cff931b7"), new Guid("d2f3c9a1-46e5-40d6-b782-674ba61334c8"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1168), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1169) },
                    { new Guid("1f4098c0-8e99-4e57-9786-5e58a0832398"), new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"), new Guid("9cf403ae-6c10-47aa-95ca-5dc3403ec2da"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1189), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1190) },
                    { new Guid("5601e689-455c-492d-8ec5-55b950101d56"), new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"), new Guid("090e58d6-0f99-471d-a614-9401882fadcb"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1202), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1203) },
                    { new Guid("987efd68-63f7-4b3a-a029-3c57d65126a8"), new Guid("b2d8a25a-01b3-454a-bb62-c829cff931b7"), new Guid("32b45778-764a-4ae0-9a44-5555d189d6a9"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1152), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1160) },
                    { new Guid("d1cc1ed8-0474-44d7-91a5-219f4325171e"), new Guid("286f574b-b842-4930-86c1-b873350a0d98"), new Guid("9cf403ae-6c10-47aa-95ca-5dc3403ec2da"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1196), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1197) },
                    { new Guid("e25b2548-6d17-4f83-a58e-608278bc1801"), new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"), new Guid("d7584f4f-5b7e-4102-886c-20a59cd22752"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1209), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1210) },
                    { new Guid("fba9d159-8866-4458-a1b3-5828af05fd40"), new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"), new Guid("34645ff8-7bd8-42d6-9749-1beae05ff7ad"), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1183), new DateTime(2024, 4, 2, 15, 33, 8, 773, DateTimeKind.Local).AddTicks(1184) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_ArtistaId",
                table: "Album",
                column: "ArtistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Album_DiscograficaId",
                table: "Album",
                column: "DiscograficaId");

            migrationBuilder.CreateIndex(
                name: "IX_Album_GeneroId",
                table: "Album",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Cancion_AlbumId",
                table: "Cancion",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboracion_CancionId",
                table: "Colaboracion",
                column: "CancionId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorito_CancionId",
                table: "Favorito",
                column: "CancionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistDetalle_CancionId",
                table: "PlaylistDetalle",
                column: "CancionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistDetalle_PlaylistId",
                table: "PlaylistDetalle",
                column: "PlaylistId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colaboracion");

            migrationBuilder.DropTable(
                name: "Favorito");

            migrationBuilder.DropTable(
                name: "PlaylistDetalle");

            migrationBuilder.DropTable(
                name: "Cancion");

            migrationBuilder.DropTable(
                name: "Playlist");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Artista");

            migrationBuilder.DropTable(
                name: "Discografica");

            migrationBuilder.DropTable(
                name: "Genero");
        }
    }
}
