﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleRegistrationPage.Models;

namespace SimpleRegistrationPage.Migrations
{
    [DbContext(typeof(AccountContext))]
    partial class AccountContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimpleRegistrationPage.Models.Account", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("confirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gender")
                        .HasColumnType("bit");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.HasKey("username");

                    b.ToTable("AccountsFrontEnd");
                });

            modelBuilder.Entity("SimpleRegistratorPageLibrary.Model.Account", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("email")
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("gender")
                        .HasColumnType("bit");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.HasKey("username");

                    b.ToTable("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
