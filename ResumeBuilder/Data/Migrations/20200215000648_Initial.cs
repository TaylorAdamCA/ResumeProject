using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeBuilder.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalProfiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(type: "varchar(128)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(128)", nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Address = table.Column<string>(type: "varchar(256)", nullable: false),
                    Country = table.Column<string>(type: "varchar(74)", nullable: false),
                    CountryCode = table.Column<string>(type: "varchar(2)", nullable: true),
                    PostalCode = table.Column<string>(type: "varchar(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(type: "varchar(256)", nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", nullable: false),
                    PersonalProfileId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Links_PersonalProfiles_PersonalProfileId",
                        column: x => x.PersonalProfileId,
                        principalTable: "PersonalProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Links_PersonalProfileId",
                table: "Links",
                column: "PersonalProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "PersonalProfiles");
        }
    }
}
