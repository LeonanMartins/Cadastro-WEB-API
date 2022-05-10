using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadastro.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoFormacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataContacto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Retorno = table.Column<bool>(type: "bit", nullable: false),
                    NumeroContactos = table.Column<int>(type: "int", nullable: false),
                    PrimeiroContacto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoContacto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contacto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
