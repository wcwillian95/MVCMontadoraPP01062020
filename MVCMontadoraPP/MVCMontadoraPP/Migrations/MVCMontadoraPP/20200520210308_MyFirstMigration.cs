using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCMontadoraPP.Migrations.MVCMontadoraPP
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Cliente = table.Column<string>(nullable: true),
                    CPF_Cliente = table.Column<string>(nullable: true),
                    Contato_Cliente = table.Column<string>(nullable: true),
                    Contatodois_Cliente = table.Column<string>(nullable: true),
                    Email_Cliente = table.Column<string>(nullable: true),
                    CEP_Cliente = table.Column<string>(nullable: true),
                    Rua_Cliente = table.Column<string>(nullable: true),
                    Bairro_Cliente = table.Column<string>(nullable: true),
                    Cidade_Cliente = table.Column<string>(nullable: true),
                    Estado_Cliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
