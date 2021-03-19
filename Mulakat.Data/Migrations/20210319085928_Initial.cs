using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mulakat.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedDate", "Poster", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("43155072-0b94-4c98-a718-e05e01095d17"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 338, DateTimeKind.Local).AddTicks(9119), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 338, DateTimeKind.Local).AddTicks(9150), "https://m.media-amazon.com/images/M/MV5BOTY4YjI2N2MtYmFlMC00ZjcyLTg3YjEtMDQyM2ZjYzQ5YWFkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "Batman Begins", "2005" },
                    { new Guid("4f886738-f6ec-43a4-9879-491ce28284b0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(1263), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(1289), "https://m.media-amazon.com/images/M/MV5BYThjYzcyYzItNTVjNy00NDk0LTgwMWQtYjMwNmNlNWJhMzMyXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "Batman v Superman: Dawn of Justice", "2016" },
                    { new Guid("280073c1-b23f-4fd4-9cb4-7833407df3f6"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(1598), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(1601), "https://m.media-amazon.com/images/M/MV5BMTYwNjAyODIyMF5BMl5BanBnXkFtZTYwNDMwMDk2._V1_SX300.jpg", "Batman", "1989" },
                    { new Guid("cd62d581-cf0d-4d13-bc0f-2043d13c35c9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(1651), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(1652), "https://m.media-amazon.com/images/M/MV5BOGZmYzVkMmItM2NiOS00MDI3LWI4ZWQtMTg0YWZkODRkMmViXkEyXkFqcGdeQXVyODY0NzcxNw@@._V1_SX300.jpg", "Batman Returns", "1992" },
                    { new Guid("09958524-27dd-44e3-b792-fd1d9e8b148a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(1693), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(1695), "https://m.media-amazon.com/images/M/MV5BMGQ5YTM1NmMtYmIxYy00N2VmLWJhZTYtN2EwYTY3MWFhOTczXkEyXkFqcGdeQXVyNTA2NTI0MTY@._V1_SX300.jpg", "Batman & Robin", "1997" },
                    { new Guid("5ee056a4-a047-4a2f-b29f-f2cd27305d7e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(2604), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(2610), "https://m.media-amazon.com/images/M/MV5BNDdjYmFiYWEtYzBhZS00YTZkLWFlODgtY2I5MDE0NzZmMDljXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SX300.jpg", "Batman Forever", "1995" },
                    { new Guid("a8e0937a-b77c-43c2-8e43-35c944d291ca"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(2656), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(2657), "https://m.media-amazon.com/images/M/MV5BMTcyNTEyOTY0M15BMl5BanBnXkFtZTgwOTAyNzU3MDI@._V1_SX300.jpg", "The Lego Batman Movie", "2017" },
                    { new Guid("e8940858-8af4-4139-86cd-dde9a1aab0c7"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(2741), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(2742), "https://m.media-amazon.com/images/M/MV5BOTM3MTRkZjQtYjBkMy00YWE1LTkxOTQtNDQyNGY0YjYzNzAzXkEyXkFqcGdeQXVyOTgwMzk1MTA@._V1_SX300.jpg", "Batman: The Animated Series", "1992–1995" },
                    { new Guid("b334a170-3323-42b9-9091-5d9a96a66650"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(2783), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(2784), "https://m.media-amazon.com/images/M/MV5BNmY4ZDZjY2UtOWFiYy00MjhjLThmMjctOTQ2NjYxZGRjYmNlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX300.jpg", "Batman: Under the Red Hood", "2010" },
                    { new Guid("f774677b-9f72-4de5-8857-5e969259b5ec"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(4063), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 3, 19, 11, 59, 28, 356, DateTimeKind.Local).AddTicks(4069), "https://m.media-amazon.com/images/M/MV5BMzIxMDkxNDM2M15BMl5BanBnXkFtZTcwMDA5ODY1OQ@@._V1_SX300.jpg", "Batman: The Dark Knight Returns, Part 1", "2012" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
