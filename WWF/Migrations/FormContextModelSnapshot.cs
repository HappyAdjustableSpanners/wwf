﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WWF.Models;

namespace WWF.Migrations
{
    [DbContext(typeof(FormContext))]
    partial class FormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WWF.Models.FormData", b =>
                {
                    b.Property<int>("FormDataId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(35);

                    b.Property<string>("AddressLine3")
                        .HasMaxLength(35);

                    b.Property<string>("AddressLine4")
                        .HasMaxLength(35);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(255);

                    b.Property<string>("CountryCode")
                        .HasMaxLength(35);

                    b.Property<string>("County")
                        .HasMaxLength(35);

                    b.Property<string>("Forenames")
                        .HasMaxLength(30);

                    b.Property<string>("Honorifics")
                        .HasMaxLength(30);

                    b.Property<string>("Initials")
                        .HasMaxLength(7);

                    b.Property<string>("Postcode")
                        .HasMaxLength(10);

                    b.Property<string>("Signature")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Title")
                        .HasMaxLength(40);

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.HasKey("FormDataId");

                    b.ToTable("FormSubmissions");
                });
#pragma warning restore 612, 618
        }
    }
}
