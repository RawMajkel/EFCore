using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Persistance.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), "Alvena Halvorson" },
                    { new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"), "Raven Thiel" },
                    { new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), "Marques Sporer" },
                    { new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"), "Chelsey Schiller" },
                    { new Guid("8e3c5f4c-1cef-4620-b521-0871cc0019f4"), "Antonietta Howe" },
                    { new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"), "Abby Upton" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "FirstName", "LastName", "TeamId", "Title" },
                values: new object[,]
                {
                    { new Guid("e01bec10-1760-4e25-a123-32d1d8475661"), "Tony", "Rosenbaum", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 0 },
                    { new Guid("9e526d9f-7b46-461a-a814-0281ea9e8405"), "Alf", "Thiel", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 1 },
                    { new Guid("5eb22c0d-fdbe-439f-8315-f09d3be62748"), "Orpha", "Gutmann", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 0 },
                    { new Guid("40963979-412d-4fa9-b390-6b806a4e09c5"), "Jazmin", "Mueller", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 0 },
                    { new Guid("420186c4-a38e-4b67-a468-a26a96223421"), "Cory", "West", new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"), 1 },
                    { new Guid("9a2be380-3319-492c-a8cb-c5080335cd86"), "Sigrid", "Wolff", new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"), 0 },
                    { new Guid("bc3c0f30-d7eb-49f8-afd8-c234ccc36a80"), "Alfonzo", "Cormier", new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"), 1 },
                    { new Guid("e272eeb0-1436-4abd-bc0a-02e1e5af9a81"), "Theo", "Kunze", new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"), 2 },
                    { new Guid("91f2a423-459f-4179-8c8f-1afba03633e8"), "Turner", "Legros", new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"), 2 },
                    { new Guid("d40b7e82-bde9-4fce-a79b-131e5ec3c64b"), "Tom", "Murazik", new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"), 0 },
                    { new Guid("ac72bb79-9fe0-4243-86a9-81f44b9a7a0f"), "Marion", "Legros", new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"), 0 },
                    { new Guid("de83be70-b2b5-403f-80a5-48d229f0af71"), "Daija", "Dietrich", new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"), 2 },
                    { new Guid("e14f2c9f-e613-4a3f-81ab-46587c2b91e8"), "Maci", "Kemmer", new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"), 0 },
                    { new Guid("2541d72f-8137-4f72-b609-7e2b7f321163"), "Concepcion", "Gutmann", new Guid("8e3c5f4c-1cef-4620-b521-0871cc0019f4"), 2 },
                    { new Guid("98cfc36d-eaff-4ea5-822b-ccb3619a7125"), "Priscilla", "Yost", new Guid("8e3c5f4c-1cef-4620-b521-0871cc0019f4"), 2 },
                    { new Guid("1f5ed241-7914-4198-88d5-457a3f13335c"), "Elenor", "Breitenberg", new Guid("8e3c5f4c-1cef-4620-b521-0871cc0019f4"), 2 },
                    { new Guid("bf875e75-4bc7-4e20-8e1e-69b548700ba8"), "Lafayette", "Runte", new Guid("8e3c5f4c-1cef-4620-b521-0871cc0019f4"), 2 },
                    { new Guid("85102192-f361-4833-8dbc-3ae3de5ebdd7"), "Matilde", "Lynch", new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"), 2 },
                    { new Guid("ac11a1f8-4b67-4132-ba8d-9c5ecf077c40"), "Raphaelle", "Hills", new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"), 2 },
                    { new Guid("6c06b8e4-2f6e-4fab-a009-5233437abfcf"), "Mario", "Parker", new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"), 1 },
                    { new Guid("de447fd5-cb95-4a01-b949-c19bb4a173b9"), "Giovanni", "Hettinger", new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"), 1 },
                    { new Guid("a4343982-736f-4680-af06-2fd5efeebd27"), "Yazmin", "Crooks", new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"), 1 },
                    { new Guid("a865a28e-6080-4c19-bfa7-78c36123e698"), "Patience", "Bernier", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 0 },
                    { new Guid("7b44aa9b-69fb-4700-8afa-2e3422c6f0e4"), "Deven", "Collier", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 1 },
                    { new Guid("d6b68e9f-51e7-4778-9a8b-5b8dca3054fc"), "Rosa", "Windler", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 2 },
                    { new Guid("8796149d-9324-4c02-839f-99c2277c4654"), "Annamae", "Ankunding", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 1 },
                    { new Guid("a9edb54c-62d9-492a-b1c5-96550efb769f"), "Anderson", "Bins", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 1 },
                    { new Guid("4e444c31-662b-4f48-bd9d-7461d93e86eb"), "Orland", "Cummerata", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 0 },
                    { new Guid("81b00171-0c73-4bad-9713-fa6fad727994"), "Merle", "Murphy", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 1 },
                    { new Guid("d8e4ea45-a715-4c58-8155-0126ec7901ae"), "Raphael", "Boyer", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 2 },
                    { new Guid("1ba20347-1b1f-4979-8ea7-f495e790fce5"), "Arnoldo", "Lemke", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 2 },
                    { new Guid("be9ef334-b83e-4ee2-943a-2eaa06ff0822"), "Dolly", "Berge", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 2 },
                    { new Guid("ae7469b0-409e-4167-98c6-12481601d009"), "Arely", "Kuphal", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 2 },
                    { new Guid("5b7a2919-752d-4f5c-ad03-4bb688c5cd3b"), "Clifford", "Gutmann", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 2 },
                    { new Guid("19bc548b-6fd2-4afe-8938-27bca423bc55"), "Ethel", "D'Amore", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 0 },
                    { new Guid("2ca3a40d-6708-4670-ac9a-3305896e3c25"), "Dannie", "Welch", new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"), 2 },
                    { new Guid("3c027483-f4a4-47e4-bc18-bda804af5685"), "Lottie", "Cole", new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"), 2 },
                    { new Guid("891e9e23-74b9-4458-ac82-60f5fd9b6394"), "Dagmar", "Conn", new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"), 1 },
                    { new Guid("7f6b9bd0-c8b2-4f09-a922-6c896a5cda84"), "Tiara", "Bins", new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"), 2 },
                    { new Guid("a1a0b476-25a3-4d6a-b183-1a6cb7712643"), "Carmel", "Nitzsche", new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"), 1 },
                    { new Guid("f3a08cbb-7e68-41bf-ae11-4ce013a40b44"), "Charity", "Bednar", new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"), 1 },
                    { new Guid("a4ecf374-a63f-4854-a2e7-3f0503d09ce0"), "Iliana", "Purdy", new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"), 1 }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "FirstName", "LastName", "TeamId", "Title" },
                values: new object[,]
                {
                    { new Guid("5e08589e-da9d-4447-9c0e-1bba0f90d305"), "Alena", "Bernhard", new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"), 2 },
                    { new Guid("ae9a4330-5093-47f2-b80a-8c0dc85560cb"), "Lucy", "Botsford", new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"), 2 },
                    { new Guid("5dfe2acd-5343-4864-8e89-cb7fb72dc596"), "Carmine", "O'Kon", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 2 },
                    { new Guid("68c67847-4339-4236-93f5-a608a6d1e11c"), "Fredy", "Steuber", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 2 },
                    { new Guid("07016d71-ce8d-48fb-8c91-16eb373ec0f1"), "Laurel", "Kuhlman", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 1 },
                    { new Guid("b1c90b47-3fd1-488b-aa30-fc671a1ea57b"), "Anjali", "Hamill", new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"), 1 },
                    { new Guid("5b3a445b-3e9c-4850-8685-c6a4bb433784"), "Dawson", "Hamill", new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"), 1 },
                    { new Guid("e8cd8bd8-88dc-4152-b4b0-c9e2fddab49c"), "Dorthy", "Fahey", new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
