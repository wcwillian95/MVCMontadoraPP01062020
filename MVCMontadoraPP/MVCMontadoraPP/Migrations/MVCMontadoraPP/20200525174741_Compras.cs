using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCMontadoraPP.Migrations.MVCMontadoraPP
{
    public partial class Compras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Peca_Compra = table.Column<string>(nullable: true),
                    Fornecedor_Compra = table.Column<string>(nullable: true),
                    Quantidade_Compra = table.Column<int>(nullable: false),
                    ValorUnitatio_Compra = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ValorTotal_Compra = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Fornecedor = table.Column<string>(nullable: true),
                    CNPJ_Fornecedor = table.Column<string>(nullable: true),
                    Contato_Fornecedor = table.Column<string>(nullable: true),
                    Email_Fornecedor = table.Column<string>(nullable: true),
                    CEP_Fornecedor = table.Column<string>(nullable: true),
                    Rua_Fornecedor = table.Column<string>(nullable: true),
                    Bairro_Fornecedor = table.Column<string>(nullable: true),
                    Cidade_Fornecedor = table.Column<string>(nullable: true),
                    Estado_Fornecedor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Funcionario = table.Column<string>(nullable: true),
                    Cargo_Funcionario = table.Column<string>(nullable: true),
                    CPF_Funcionario = table.Column<string>(nullable: true),
                    Contato_Funcionario = table.Column<string>(nullable: true),
                    Contatodois_Funcionario = table.Column<string>(nullable: true),
                    Email_Funcionario = table.Column<string>(nullable: true),
                    CEP_Funcionario = table.Column<string>(nullable: true),
                    Rua_Funcionario = table.Column<string>(nullable: true),
                    Bairro_Funcionario = table.Column<string>(nullable: true),
                    Cidade_Funcionario = table.Column<string>(nullable: true),
                    Estado_Funcionario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Peca",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Peca = table.Column<string>(nullable: true),
                    Fornecedor_Peca = table.Column<string>(nullable: true),
                    Valor_peca = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Codigo_Peca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peca", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendedor_Venda = table.Column<string>(nullable: true),
                    Cliente_Venda = table.Column<string>(nullable: true),
                    Peca_Venda = table.Column<string>(nullable: true),
                    Quantidade_Venda = table.Column<int>(nullable: false),
                    ValorUnit_Venda = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ValorFinal_Venda = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Peca");

            migrationBuilder.DropTable(
                name: "Venda");
        }
    }
}
