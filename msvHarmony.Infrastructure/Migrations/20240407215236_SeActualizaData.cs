using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace msvHarmony.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeActualizaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: new Guid("09f84863-c6bd-4d04-a076-a145847496c8"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: new Guid("36f0c39c-006c-4ba9-b9f1-93a0cb9c2695"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(462), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: new Guid("a9cbd226-1b7b-4efe-b5d1-b2951bf16d39"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(443), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: new Guid("dddf3f3e-c737-4d93-81bf-2a15354ceee7"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(417), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5831), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("286f574b-b842-4930-86c1-b873350a0d98"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5826), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("41f40298-2bce-45b5-9cf0-6017b2b12f33"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5821), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("740d3805-1377-4e3e-962f-16b594401624"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5836), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("839d6647-abb1-4b26-b096-626be91e8fa9"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5841), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("96303db8-663d-441f-b85b-f2424dc42f4c"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5799), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("b2d8a25a-01b3-454a-bb62-c829cff931b7"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5811), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("c24fb9db-848c-4a9d-8ae0-44a97a38f0cb"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5816), new DateTime(2024, 4, 7, 16, 52, 36, 268, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("090e58d6-0f99-471d-a614-9401882fadcb"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2358), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("32b45778-764a-4ae0-9a44-5555d189d6a9"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2302), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("34645ff8-7bd8-42d6-9749-1beae05ff7ad"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("59bcaa11-7849-41e1-8e50-beb241e1d612"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2350), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("9cf403ae-6c10-47aa-95ca-5dc3403ec2da"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2343), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("d2f3c9a1-46e5-40d6-b782-674ba61334c8"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2317), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("d7584f4f-5b7e-4102-886c-20a59cd22752"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2365), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("dbf159ea-55f1-44f5-a98e-36d45b62bc28"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2326), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("05775810-99c0-4c9f-9c64-67b62a757009"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("1108f4ae-0bd1-46e3-a3d0-78f488ebd0e0"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("1f4098c0-8e99-4e57-9786-5e58a0832398"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8453), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("5601e689-455c-492d-8ec5-55b950101d56"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("987efd68-63f7-4b3a-a029-3c57d65126a8"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8415), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("d1cc1ed8-0474-44d7-91a5-219f4325171e"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8461), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("e25b2548-6d17-4f83-a58e-608278bc1801"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("fba9d159-8866-4458-a1b3-5828af05fd40"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8447), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.InsertData(
                table: "Colaboracion",
                columns: new[] { "Id", "ArtistaId", "CancionId", "CreatedOn", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("bae3e15f-dcd3-439a-bd36-332c4a6841cc"), new Guid("286f574b-b842-4930-86c1-b873350a0d98"), new Guid("59bcaa11-7849-41e1-8e50-beb241e1d612"), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8488), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8489) },
                    { new Guid("cfc16fef-a973-4748-b5ac-ca2cdfd2bf0b"), new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"), new Guid("59bcaa11-7849-41e1-8e50-beb241e1d612"), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8481), new DateTime(2024, 4, 7, 16, 52, 36, 269, DateTimeKind.Local).AddTicks(8482) }
                });

            migrationBuilder.UpdateData(
                table: "Discografica",
                keyColumn: "Id",
                keyValue: new Guid("315721f0-9942-4ca2-a7cb-af423dac1d20"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 270, DateTimeKind.Local).AddTicks(2452), new DateTime(2024, 4, 7, 16, 52, 36, 270, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Discografica",
                keyColumn: "Id",
                keyValue: new Guid("34a47160-6312-4f1f-a220-4608acb7daac"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 270, DateTimeKind.Local).AddTicks(2447), new DateTime(2024, 4, 7, 16, 52, 36, 270, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Discografica",
                keyColumn: "Id",
                keyValue: new Guid("71f1d39b-5fbd-42d7-b4df-a904880b904d"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 270, DateTimeKind.Local).AddTicks(2442), new DateTime(2024, 4, 7, 16, 52, 36, 270, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Discografica",
                keyColumn: "Id",
                keyValue: new Guid("7e49603a-44e5-48d3-990c-691008b0e88a"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 270, DateTimeKind.Local).AddTicks(2429), new DateTime(2024, 4, 7, 16, 52, 36, 270, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("005ec1d9-e027-4000-bf14-007b1dd5a1a4"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("0a2cee36-6643-43b3-b0a3-ae29aa36ebb6"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2503), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("1fe91b74-2e0a-44aa-9229-8c12d985eda9"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2508), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("4eb68ff4-7b9c-4618-b64b-a91f51c4bb25"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("541dfa54-35fc-4a70-8aae-cb7b88912945"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2532), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("8eecad94-b361-45fa-80e5-e11a424f9388"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2512), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("8fed34da-dbe0-4ffb-b7e4-59b1546d446e"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2482), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("b0b3b676-2509-4557-93f3-91d5c134f404"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("b2a94699-9ff0-4e2c-a867-4e915aa86d3a"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2498), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("baa5cc89-28d4-4ce0-8210-24b1ec453fdf"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2522), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("c0fa37f3-5fb3-41d2-ba70-05fcbd352218"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2541), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("cdc4a9d0-9618-413c-b8ef-3c75b2f87aa4"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2468), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("d9df4cc3-7d0d-45ce-959b-7fb34aac6d58"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("ecb3ea6f-e1db-497a-b777-b58bf7f4f77f"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2536), new DateTime(2024, 4, 7, 16, 52, 36, 271, DateTimeKind.Local).AddTicks(2537) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("bae3e15f-dcd3-439a-bd36-332c4a6841cc"));

            migrationBuilder.DeleteData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("cfc16fef-a973-4748-b5ac-ca2cdfd2bf0b"));

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: new Guid("09f84863-c6bd-4d04-a076-a145847496c8"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 589, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 4, 2, 15, 34, 50, 589, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: new Guid("36f0c39c-006c-4ba9-b9f1-93a0cb9c2695"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 589, DateTimeKind.Local).AddTicks(8578), new DateTime(2024, 4, 2, 15, 34, 50, 589, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: new Guid("a9cbd226-1b7b-4efe-b5d1-b2951bf16d39"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 589, DateTimeKind.Local).AddTicks(8560), new DateTime(2024, 4, 2, 15, 34, 50, 589, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: new Guid("dddf3f3e-c737-4d93-81bf-2a15354ceee7"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 589, DateTimeKind.Local).AddTicks(8533), new DateTime(2024, 4, 2, 15, 34, 50, 589, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("00da8580-99e6-4e16-8a0b-d8739b4f98ff"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("286f574b-b842-4930-86c1-b873350a0d98"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4372), new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("41f40298-2bce-45b5-9cf0-6017b2b12f33"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4368), new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("740d3805-1377-4e3e-962f-16b594401624"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4382), new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("839d6647-abb1-4b26-b096-626be91e8fa9"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4387), new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("96303db8-663d-441f-b85b-f2424dc42f4c"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4345), new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("b2d8a25a-01b3-454a-bb62-c829cff931b7"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4358), new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Artista",
                keyColumn: "Id",
                keyValue: new Guid("c24fb9db-848c-4a9d-8ae0-44a97a38f0cb"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4363), new DateTime(2024, 4, 2, 15, 34, 50, 590, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("090e58d6-0f99-471d-a614-9401882fadcb"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1740), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("32b45778-764a-4ae0-9a44-5555d189d6a9"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1590), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("34645ff8-7bd8-42d6-9749-1beae05ff7ad"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1716), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("59bcaa11-7849-41e1-8e50-beb241e1d612"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1732), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("9cf403ae-6c10-47aa-95ca-5dc3403ec2da"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1725), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("d2f3c9a1-46e5-40d6-b782-674ba61334c8"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1606), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("d7584f4f-5b7e-4102-886c-20a59cd22752"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1747), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Cancion",
                keyColumn: "Id",
                keyValue: new Guid("dbf159ea-55f1-44f5-a98e-36d45b62bc28"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1613), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("05775810-99c0-4c9f-9c64-67b62a757009"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8230), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("1108f4ae-0bd1-46e3-a3d0-78f488ebd0e0"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("1f4098c0-8e99-4e57-9786-5e58a0832398"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8243), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("5601e689-455c-492d-8ec5-55b950101d56"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8256), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("987efd68-63f7-4b3a-a029-3c57d65126a8"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8208), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("d1cc1ed8-0474-44d7-91a5-219f4325171e"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8249), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("e25b2548-6d17-4f83-a58e-608278bc1801"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8263), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Colaboracion",
                keyColumn: "Id",
                keyValue: new Guid("fba9d159-8866-4458-a1b3-5828af05fd40"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8236), new DateTime(2024, 4, 2, 15, 34, 50, 591, DateTimeKind.Local).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "Discografica",
                keyColumn: "Id",
                keyValue: new Guid("315721f0-9942-4ca2-a7cb-af423dac1d20"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 592, DateTimeKind.Local).AddTicks(2356), new DateTime(2024, 4, 2, 15, 34, 50, 592, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Discografica",
                keyColumn: "Id",
                keyValue: new Guid("34a47160-6312-4f1f-a220-4608acb7daac"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 592, DateTimeKind.Local).AddTicks(2351), new DateTime(2024, 4, 2, 15, 34, 50, 592, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Discografica",
                keyColumn: "Id",
                keyValue: new Guid("71f1d39b-5fbd-42d7-b4df-a904880b904d"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 592, DateTimeKind.Local).AddTicks(2345), new DateTime(2024, 4, 2, 15, 34, 50, 592, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Discografica",
                keyColumn: "Id",
                keyValue: new Guid("7e49603a-44e5-48d3-990c-691008b0e88a"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 592, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 4, 2, 15, 34, 50, 592, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("005ec1d9-e027-4000-bf14-007b1dd5a1a4"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3238), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("0a2cee36-6643-43b3-b0a3-ae29aa36ebb6"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3254), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("1fe91b74-2e0a-44aa-9229-8c12d985eda9"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3259), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("4eb68ff4-7b9c-4618-b64b-a91f51c4bb25"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3270), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("541dfa54-35fc-4a70-8aae-cb7b88912945"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3285), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("8eecad94-b361-45fa-80e5-e11a424f9388"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3263), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("8fed34da-dbe0-4ffb-b7e4-59b1546d446e"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3233), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("b0b3b676-2509-4557-93f3-91d5c134f404"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3243), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("b2a94699-9ff0-4e2c-a867-4e915aa86d3a"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3250), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("baa5cc89-28d4-4ce0-8210-24b1ec453fdf"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3275), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("c0fa37f3-5fb3-41d2-ba70-05fcbd352218"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("cdc4a9d0-9618-413c-b8ef-3c75b2f87aa4"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("d9df4cc3-7d0d-45ce-959b-7fb34aac6d58"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: new Guid("ecb3ea6f-e1db-497a-b777-b58bf7f4f77f"),
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 4, 2, 15, 34, 50, 593, DateTimeKind.Local).AddTicks(3290) });
        }
    }
}
