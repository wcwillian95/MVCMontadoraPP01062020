﻿// <auto-generated />
using System;
using MVCMontadoraPP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCMontadoraPP.Migrations.MVCMontadoraPP
{
    [DbContext(typeof(MVCMontadoraPPContext))]
    partial class MVCMontadoraPPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCMontadoraPP.Models.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF_Cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Cidade_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contatodois_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastroCliente")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento_Cliente")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_Cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Rua_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("MVCMontadoraPP.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastroCompra")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fornecedor_Compra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peca_Compra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade_Compra")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTotal_Compra")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("ValorUnitatio_Compra")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("MVCMontadoraPP.Models.Fornecedor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro_Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP_Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNPJ_Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade_Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato_Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastroFornecedor")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email_Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado_Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua_Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("MVCMontadoraPP.Models.Funcionario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contatodois_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastroFuncionario")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento_Funcionario")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua_Funcionario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("MVCMontadoraPP.Models.Peca", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo_Peca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fornecedor_Peca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_Peca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor_peca")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("ID");

                    b.ToTable("Peca");
                });

            modelBuilder.Entity("MVCMontadoraPP.Models.Venda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cliente_Venda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastroVenda")
                        .HasColumnType("datetime2");

                    b.Property<string>("Peca_Venda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade_Venda")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorFinal_Venda")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("ValorUnit_Venda")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Vendedor_Venda")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Venda");
                });
#pragma warning restore 612, 618
        }
    }
}
