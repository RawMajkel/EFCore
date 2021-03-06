﻿// <auto-generated />
using System;
using EFCore.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.Persistance.Migrations
{
    [DbContext(typeof(EfCoreContext))]
    partial class EfCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EFCore.Persistance.Model.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Name = "Alvena Halvorson"
                        },
                        new
                        {
                            Id = new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"),
                            Name = "Raven Thiel"
                        },
                        new
                        {
                            Id = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Name = "Marques Sporer"
                        },
                        new
                        {
                            Id = new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"),
                            Name = "Chelsey Schiller"
                        },
                        new
                        {
                            Id = new Guid("8e3c5f4c-1cef-4620-b521-0871cc0019f4"),
                            Name = "Antonietta Howe"
                        },
                        new
                        {
                            Id = new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"),
                            Name = "Abby Upton"
                        });
                });

            modelBuilder.Entity("EFCore.Persistance.Model.TeamMember", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Title")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e01bec10-1760-4e25-a123-32d1d8475661"),
                            FirstName = "Tony",
                            LastName = "Rosenbaum",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 0
                        },
                        new
                        {
                            Id = new Guid("891e9e23-74b9-4458-ac82-60f5fd9b6394"),
                            FirstName = "Dagmar",
                            LastName = "Conn",
                            TeamId = new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("5dfe2acd-5343-4864-8e89-cb7fb72dc596"),
                            FirstName = "Carmine",
                            LastName = "O'Kon",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("a9edb54c-62d9-492a-b1c5-96550efb769f"),
                            FirstName = "Anderson",
                            LastName = "Bins",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("85102192-f361-4833-8dbc-3ae3de5ebdd7"),
                            FirstName = "Matilde",
                            LastName = "Lynch",
                            TeamId = new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("5b3a445b-3e9c-4850-8685-c6a4bb433784"),
                            FirstName = "Dawson",
                            LastName = "Hamill",
                            TeamId = new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("ac11a1f8-4b67-4132-ba8d-9c5ecf077c40"),
                            FirstName = "Raphaelle",
                            LastName = "Hills",
                            TeamId = new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("4e444c31-662b-4f48-bd9d-7461d93e86eb"),
                            FirstName = "Orland",
                            LastName = "Cummerata",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 0
                        },
                        new
                        {
                            Id = new Guid("2541d72f-8137-4f72-b609-7e2b7f321163"),
                            FirstName = "Concepcion",
                            LastName = "Gutmann",
                            TeamId = new Guid("8e3c5f4c-1cef-4620-b521-0871cc0019f4"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("420186c4-a38e-4b67-a468-a26a96223421"),
                            FirstName = "Cory",
                            LastName = "West",
                            TeamId = new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("81b00171-0c73-4bad-9713-fa6fad727994"),
                            FirstName = "Merle",
                            LastName = "Murphy",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("68c67847-4339-4236-93f5-a608a6d1e11c"),
                            FirstName = "Fredy",
                            LastName = "Steuber",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("98cfc36d-eaff-4ea5-822b-ccb3619a7125"),
                            FirstName = "Priscilla",
                            LastName = "Yost",
                            TeamId = new Guid("8e3c5f4c-1cef-4620-b521-0871cc0019f4"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("d8e4ea45-a715-4c58-8155-0126ec7901ae"),
                            FirstName = "Raphael",
                            LastName = "Boyer",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("1ba20347-1b1f-4979-8ea7-f495e790fce5"),
                            FirstName = "Arnoldo",
                            LastName = "Lemke",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("1f5ed241-7914-4198-88d5-457a3f13335c"),
                            FirstName = "Elenor",
                            LastName = "Breitenberg",
                            TeamId = new Guid("8e3c5f4c-1cef-4620-b521-0871cc0019f4"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("6c06b8e4-2f6e-4fab-a009-5233437abfcf"),
                            FirstName = "Mario",
                            LastName = "Parker",
                            TeamId = new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("7f6b9bd0-c8b2-4f09-a922-6c896a5cda84"),
                            FirstName = "Tiara",
                            LastName = "Bins",
                            TeamId = new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("9a2be380-3319-492c-a8cb-c5080335cd86"),
                            FirstName = "Sigrid",
                            LastName = "Wolff",
                            TeamId = new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"),
                            Title = 0
                        },
                        new
                        {
                            Id = new Guid("be9ef334-b83e-4ee2-943a-2eaa06ff0822"),
                            FirstName = "Dolly",
                            LastName = "Berge",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("a1a0b476-25a3-4d6a-b183-1a6cb7712643"),
                            FirstName = "Carmel",
                            LastName = "Nitzsche",
                            TeamId = new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("07016d71-ce8d-48fb-8c91-16eb373ec0f1"),
                            FirstName = "Laurel",
                            LastName = "Kuhlman",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("ae7469b0-409e-4167-98c6-12481601d009"),
                            FirstName = "Arely",
                            LastName = "Kuphal",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("b1c90b47-3fd1-488b-aa30-fc671a1ea57b"),
                            FirstName = "Anjali",
                            LastName = "Hamill",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("8796149d-9324-4c02-839f-99c2277c4654"),
                            FirstName = "Annamae",
                            LastName = "Ankunding",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("bf875e75-4bc7-4e20-8e1e-69b548700ba8"),
                            FirstName = "Lafayette",
                            LastName = "Runte",
                            TeamId = new Guid("8e3c5f4c-1cef-4620-b521-0871cc0019f4"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("f3a08cbb-7e68-41bf-ae11-4ce013a40b44"),
                            FirstName = "Charity",
                            LastName = "Bednar",
                            TeamId = new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("5b7a2919-752d-4f5c-ad03-4bb688c5cd3b"),
                            FirstName = "Clifford",
                            LastName = "Gutmann",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("de447fd5-cb95-4a01-b949-c19bb4a173b9"),
                            FirstName = "Giovanni",
                            LastName = "Hettinger",
                            TeamId = new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("19bc548b-6fd2-4afe-8938-27bca423bc55"),
                            FirstName = "Ethel",
                            LastName = "D'Amore",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 0
                        },
                        new
                        {
                            Id = new Guid("d6b68e9f-51e7-4778-9a8b-5b8dca3054fc"),
                            FirstName = "Rosa",
                            LastName = "Windler",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("a4343982-736f-4680-af06-2fd5efeebd27"),
                            FirstName = "Yazmin",
                            LastName = "Crooks",
                            TeamId = new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("7b44aa9b-69fb-4700-8afa-2e3422c6f0e4"),
                            FirstName = "Deven",
                            LastName = "Collier",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("3c027483-f4a4-47e4-bc18-bda804af5685"),
                            FirstName = "Lottie",
                            LastName = "Cole",
                            TeamId = new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("a4ecf374-a63f-4854-a2e7-3f0503d09ce0"),
                            FirstName = "Iliana",
                            LastName = "Purdy",
                            TeamId = new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("e8cd8bd8-88dc-4152-b4b0-c9e2fddab49c"),
                            FirstName = "Dorthy",
                            LastName = "Fahey",
                            TeamId = new Guid("6747340f-92d1-4844-b2ce-7dad6509d88a"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("bc3c0f30-d7eb-49f8-afd8-c234ccc36a80"),
                            FirstName = "Alfonzo",
                            LastName = "Cormier",
                            TeamId = new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("a865a28e-6080-4c19-bfa7-78c36123e698"),
                            FirstName = "Patience",
                            LastName = "Bernier",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 0
                        },
                        new
                        {
                            Id = new Guid("9e526d9f-7b46-461a-a814-0281ea9e8405"),
                            FirstName = "Alf",
                            LastName = "Thiel",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 1
                        },
                        new
                        {
                            Id = new Guid("5eb22c0d-fdbe-439f-8315-f09d3be62748"),
                            FirstName = "Orpha",
                            LastName = "Gutmann",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 0
                        },
                        new
                        {
                            Id = new Guid("e272eeb0-1436-4abd-bc0a-02e1e5af9a81"),
                            FirstName = "Theo",
                            LastName = "Kunze",
                            TeamId = new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("5e08589e-da9d-4447-9c0e-1bba0f90d305"),
                            FirstName = "Alena",
                            LastName = "Bernhard",
                            TeamId = new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("91f2a423-459f-4179-8c8f-1afba03633e8"),
                            FirstName = "Turner",
                            LastName = "Legros",
                            TeamId = new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("d40b7e82-bde9-4fce-a79b-131e5ec3c64b"),
                            FirstName = "Tom",
                            LastName = "Murazik",
                            TeamId = new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"),
                            Title = 0
                        },
                        new
                        {
                            Id = new Guid("40963979-412d-4fa9-b390-6b806a4e09c5"),
                            FirstName = "Jazmin",
                            LastName = "Mueller",
                            TeamId = new Guid("d5d78d4b-96ed-4284-92c9-7eb231950ec7"),
                            Title = 0
                        },
                        new
                        {
                            Id = new Guid("ac72bb79-9fe0-4243-86a9-81f44b9a7a0f"),
                            FirstName = "Marion",
                            LastName = "Legros",
                            TeamId = new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"),
                            Title = 0
                        },
                        new
                        {
                            Id = new Guid("ae9a4330-5093-47f2-b80a-8c0dc85560cb"),
                            FirstName = "Lucy",
                            LastName = "Botsford",
                            TeamId = new Guid("9699a898-2d81-4508-8af3-8f9e88a4c4e3"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("de83be70-b2b5-403f-80a5-48d229f0af71"),
                            FirstName = "Daija",
                            LastName = "Dietrich",
                            TeamId = new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"),
                            Title = 2
                        },
                        new
                        {
                            Id = new Guid("e14f2c9f-e613-4a3f-81ab-46587c2b91e8"),
                            FirstName = "Maci",
                            LastName = "Kemmer",
                            TeamId = new Guid("1c9e9259-6e83-4d52-85fe-d81bcd7dc44c"),
                            Title = 0
                        },
                        new
                        {
                            Id = new Guid("2ca3a40d-6708-4670-ac9a-3305896e3c25"),
                            FirstName = "Dannie",
                            LastName = "Welch",
                            TeamId = new Guid("433822eb-250e-40fa-84e3-df9e830d38c9"),
                            Title = 2
                        });
                });

            modelBuilder.Entity("EFCore.Persistance.Model.TeamMember", b =>
                {
                    b.HasOne("EFCore.Persistance.Model.Team", "Team")
                        .WithMany("Members")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("EFCore.Persistance.Model.Team", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
