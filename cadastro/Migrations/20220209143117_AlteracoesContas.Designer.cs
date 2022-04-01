﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cadastro.Models;

namespace cadastro.Migrations
{
    [DbContext(typeof(ContextoDb))]
    [Migration("20220209143117_AlteracoesContas")]
    partial class AlteracoesContas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("cadastro.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(155)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .HasMaxLength(17)
                        .HasColumnType("varchar(17)")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("cadastro.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("Agencia")
                        .HasColumnType("int")
                        .HasColumnName("Agencia");

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<double>("Saldo")
                        .HasColumnType("double")
                        .HasColumnName("Saldo");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("ClienteID");

                    b.ToTable("contas");
                });

            modelBuilder.Entity("cadastro.Models.Conta", b =>
                {
                    b.HasOne("cadastro.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}