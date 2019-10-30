﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prodavnica.DAL.Context;

namespace Prodavnica.DAL.Context.Migrations
{
    [DbContext(typeof(ProdavnicaContext))]
    [Migration("20190918125501_VrsteMaterijala")]
    partial class VrsteMaterijala
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Prodavnica.Common.Models.Materijal", b =>
                {
                    b.Property<int>("MaterijalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("MaterijalId");

                    b.ToTable("Materijali");
                });

            modelBuilder.Entity("Prodavnica.Common.Models.VrstaMaterijala", b =>
                {
                    b.Property<int>("VrstaMaterijalaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cena");

                    b.Property<string>("Dobavljac");

                    b.Property<int>("Kolicina");

                    b.Property<int>("MaterijalId");

                    b.Property<string>("Naziv");

                    b.Property<string>("SifraMaterijala");

                    b.HasKey("VrstaMaterijalaId");

                    b.HasIndex("MaterijalId");

                    b.ToTable("VrsteMaterijala");
                });

            modelBuilder.Entity("Prodavnica.Common.Models.VrstaMaterijala", b =>
                {
                    b.HasOne("Prodavnica.Common.Models.Materijal", "Materijal")
                        .WithMany()
                        .HasForeignKey("MaterijalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}