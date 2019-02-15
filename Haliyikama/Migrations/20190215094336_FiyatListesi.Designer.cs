﻿// <auto-generated />
using System;
using Haliyikama.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Haliyikama.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190215094336_FiyatListesi")]
    partial class FiyatListesi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Haliyikama.Data.Models.AltHizmet", b =>
                {
                    b.Property<int>("AltHizmetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("HizmetId");

                    b.Property<string>("Name");

                    b.HasKey("AltHizmetId");

                    b.HasIndex("HizmetId");

                    b.ToTable("AltHizmetler");
                });

            modelBuilder.Entity("Haliyikama.Data.Models.FiyatListesi", b =>
                {
                    b.Property<int>("FiyatId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Price");

                    b.HasKey("FiyatId");

                    b.ToTable("FiyatListesi");
                });

            modelBuilder.Entity("Haliyikama.Data.Models.Hakkimizda", b =>
                {
                    b.Property<int>("HakkimizdaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Title");

                    b.HasKey("HakkimizdaId");

                    b.ToTable("Hakkimizda");
                });

            modelBuilder.Entity("Haliyikama.Data.Models.Hizmet", b =>
                {
                    b.Property<int>("HizmetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsDiscounted");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<int>("NewPrice");

                    b.Property<int>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("HizmetId");

                    b.ToTable("Hizmetler");
                });

            modelBuilder.Entity("Haliyikama.Data.Models.Ilce", b =>
                {
                    b.Property<int>("IlceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageURL");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<string>("ShortDescription");

                    b.HasKey("IlceId");

                    b.ToTable("Ilceler");
                });

            modelBuilder.Entity("Haliyikama.Data.Models.Semt", b =>
                {
                    b.Property<int>("SemtId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("IlceId");

                    b.Property<string>("Name");

                    b.HasKey("SemtId");

                    b.HasIndex("IlceId");

                    b.ToTable("Semtler");
                });

            modelBuilder.Entity("Haliyikama.Data.Models.AltHizmet", b =>
                {
                    b.HasOne("Haliyikama.Data.Models.Hizmet", "Hizmet")
                        .WithMany("AltHizmetler")
                        .HasForeignKey("HizmetId");
                });

            modelBuilder.Entity("Haliyikama.Data.Models.Semt", b =>
                {
                    b.HasOne("Haliyikama.Data.Models.Ilce", "Ilce")
                        .WithMany("Semtler")
                        .HasForeignKey("IlceId");
                });
#pragma warning restore 612, 618
        }
    }
}
