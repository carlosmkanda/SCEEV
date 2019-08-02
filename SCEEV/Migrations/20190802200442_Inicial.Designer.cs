﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCEEV;

namespace SCEEV.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190802200442_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SCEEV.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Cliente");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Cliente");
                });

            modelBuilder.Entity("SCEEV.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired();

                    b.Property<string>("CEP")
                        .IsRequired();

                    b.Property<int?>("ClienteId");

                    b.Property<string>("Complemento");

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<string>("Logradouro")
                        .IsRequired();

                    b.Property<string>("Municipio")
                        .IsRequired();

                    b.Property<int>("Numero");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SCEEV.Models.Mercadoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("QuantidadeEstoque");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Mercadoria");
                });

            modelBuilder.Entity("SCEEV.Models.MercadoriaOrcamento", b =>
                {
                    b.Property<int>("MercadoriaId");

                    b.Property<int>("OrcamentoId");

                    b.HasKey("MercadoriaId", "OrcamentoId");

                    b.HasIndex("OrcamentoId");

                    b.ToTable("MercadoriaOrcamento");
                });

            modelBuilder.Entity("SCEEV.Models.Orcamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId");

                    b.Property<int>("ResponsavelId");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("Orcamento");
                });

            modelBuilder.Entity("SCEEV.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FormaDePagamento");

                    b.Property<int>("Parcelas");

                    b.Property<int>("StatusDePagamento");

                    b.Property<int>("VendaId");

                    b.HasKey("Id");

                    b.HasIndex("VendaId")
                        .IsUnique();

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("SCEEV.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId");

                    b.Property<string>("Numero")
                        .IsRequired();

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("SCEEV.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Comissao");

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<double>("Salario");

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SCEEV.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId");

                    b.Property<DateTime>("DataRealizacao");

                    b.Property<int?>("OrcamentoId");

                    b.Property<int?>("ResponsavelId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("OrcamentoId");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("SCEEV.Models.ClienteFisico", b =>
                {
                    b.HasBaseType("SCEEV.Models.Cliente");

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.HasDiscriminator().HasValue("ClienteFisico");
                });

            modelBuilder.Entity("SCEEV.Models.ClienteJuridico", b =>
                {
                    b.HasBaseType("SCEEV.Models.Cliente");

                    b.Property<string>("Cnpj")
                        .IsRequired();

                    b.HasDiscriminator().HasValue("ClienteJuridico");
                });

            modelBuilder.Entity("SCEEV.Models.Endereco", b =>
                {
                    b.HasOne("SCEEV.Models.Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("SCEEV.Models.Usuario")
                        .WithMany("Enderecos")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("SCEEV.Models.MercadoriaOrcamento", b =>
                {
                    b.HasOne("SCEEV.Models.Mercadoria", "Mercadoria")
                        .WithMany("MercadoriaOrcamentos")
                        .HasForeignKey("MercadoriaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SCEEV.Models.Orcamento", "Orcamento")
                        .WithMany("MercadoriasOrcamentos")
                        .HasForeignKey("OrcamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SCEEV.Models.Orcamento", b =>
                {
                    b.HasOne("SCEEV.Models.Cliente", "Cliente")
                        .WithMany("Orcamentos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("SCEEV.Models.Usuario", "Responsavel")
                        .WithMany("Orcamentos")
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SCEEV.Models.Pagamento", b =>
                {
                    b.HasOne("SCEEV.Models.Venda", "Venda")
                        .WithOne("Pagamento")
                        .HasForeignKey("SCEEV.Models.Pagamento", "VendaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SCEEV.Models.Telefone", b =>
                {
                    b.HasOne("SCEEV.Models.Cliente")
                        .WithMany("Telefones")
                        .HasForeignKey("ClienteId");

                    b.HasOne("SCEEV.Models.Usuario")
                        .WithMany("Telefones")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("SCEEV.Models.Venda", b =>
                {
                    b.HasOne("SCEEV.Models.Cliente", "Cliente")
                        .WithMany("Compras")
                        .HasForeignKey("ClienteId");

                    b.HasOne("SCEEV.Models.Orcamento", "Orcamento")
                        .WithMany()
                        .HasForeignKey("OrcamentoId");

                    b.HasOne("SCEEV.Models.Usuario", "Responsavel")
                        .WithMany("Vendas")
                        .HasForeignKey("ResponsavelId");
                });
#pragma warning restore 612, 618
        }
    }
}
