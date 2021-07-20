﻿// <auto-generated />
using DragonBall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DragonBall.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210718043554_PrimeiraMigration")]
    partial class PrimeiraMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DragonBall.Models.Personagem", b =>
                {
                    b.Property<int>("PersonagemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<string>("UrlImg");

                    b.HasKey("PersonagemId");

                    b.ToTable("Personagems");
                });
#pragma warning restore 612, 618
        }
    }
}
