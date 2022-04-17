﻿// <auto-generated />
using System;
using CadastroFornecedor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadastroFornecedor.Migrations
{
    [DbContext(typeof(AppCont))]
    partial class AppContModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CadastroFornecedor.Models.Empresa", b =>
                {
                    b.Property<long?>("cod_empresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("cod_empresa"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("emp_email");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("text")
                        .HasColumnName("nome_fantasia");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("text")
                        .HasColumnName("razao_social");

                    b.HasKey("cod_empresa");

                    b.ToTable("Empresa", (string)null);
                });

            modelBuilder.Entity("CadastroFornecedor.Models.Endereco", b =>
                {
                    b.Property<long?>("cod_endereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("cod_endereco"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("text")
                        .HasColumnName("end_bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)")
                        .HasColumnName("end_cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("text")
                        .HasColumnName("end_cidade");

                    b.Property<long>("Empresacod_empresa")
                        .HasColumnType("bigint");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("end_logradouro");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("end_numero");

                    b.Property<string>("Referente")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("referente");

                    b.Property<long?>("cod_empresa")
                        .HasColumnType("bigint");

                    b.HasKey("cod_endereco");

                    b.HasIndex("Empresacod_empresa");

                    b.ToTable("Endereco", (string)null);
                });

            modelBuilder.Entity("CadastroFornecedor.Models.Fornecedor", b =>
                {
                    b.Property<long?>("cod_fornecedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("cod_fornecedor"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome_contato_forn");

                    b.HasKey("cod_fornecedor");

                    b.ToTable("Fornecedor", (string)null);
                });

            modelBuilder.Entity("CadastroFornecedor.Models.FornEmp", b =>
                {
                    b.Property<long?>("cod_forn_emps")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("cod_forn_emps"), 1L, 1);

                    b.Property<long>("Empresacod_empresa")
                        .HasColumnType("bigint");

                    b.Property<long>("Fornecedorcod_fornecedor")
                        .HasColumnType("bigint");

                    b.Property<long?>("cod_empresa")
                        .HasColumnType("bigint");

                    b.Property<long?>("cod_fornecedor")
                        .HasColumnType("bigint");

                    b.HasKey("cod_forn_emps");

                    b.HasIndex("Empresacod_empresa");

                    b.HasIndex("Fornecedorcod_fornecedor");

                    b.ToTable("FornEmp", (string)null);
                });

            modelBuilder.Entity("CadastroFornecedor.Models.Endereco", b =>
                {
                    b.HasOne("CadastroFornecedor.Models.Empresa", "Empresa")
                        .WithMany("Enderecos")
                        .HasForeignKey("Empresacod_empresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("CadastroFornecedor.Models.FornEmp", b =>
                {
                    b.HasOne("CadastroFornecedor.Models.Empresa", "Empresa")
                        .WithMany("FornEmps")
                        .HasForeignKey("Empresacod_empresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CadastroFornecedor.Models.Fornecedor", "Fornecedor")
                        .WithMany("FornEmps")
                        .HasForeignKey("Fornecedorcod_fornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("CadastroFornecedor.Models.Empresa", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("FornEmps");
                });

            modelBuilder.Entity("CadastroFornecedor.Models.Fornecedor", b =>
                {
                    b.Navigation("FornEmps");
                });
#pragma warning restore 612, 618
        }
    }
}
