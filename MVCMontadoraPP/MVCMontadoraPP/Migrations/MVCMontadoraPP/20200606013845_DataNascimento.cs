using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCMontadoraPP.Migrations.MVCMontadoraPP
{
    public partial class DataNascimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastroVenda",
                table: "Venda",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastroFuncionario",
                table: "Funcionario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento_Funcionario",
                table: "Funcionario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastroFornecedor",
                table: "Fornecedor",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastroCompra",
                table: "Compra",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastroCliente",
                table: "Cliente",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento_Cliente",
                table: "Cliente",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastroVenda",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "DataCadastroFuncionario",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "DataNascimento_Funcionario",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "DataCadastroFornecedor",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "DataCadastroCompra",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "DataCadastroCliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "DataNascimento_Cliente",
                table: "Cliente");
        }
    }
}
