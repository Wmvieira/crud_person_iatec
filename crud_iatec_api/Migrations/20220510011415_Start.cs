using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_iatec_api.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    personId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.id);
                    table.ForeignKey(
                        name: "FK_Phone_Person_personId",
                        column: x => x.personId,
                        principalTable: "Person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phone_personId",
                table: "Phone",
                column: "personId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
