﻿// <auto-generated />
using System;
using Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(DbContext))]
    partial class DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Api.Models.Entities.PostEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("TagsJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Content1",
                            Created = new DateTime(2022, 4, 3, 20, 30, 7, 391, DateTimeKind.Utc).AddTicks(7902),
                            TagsJson = "[]",
                            Title = "Title1",
                            Updated = new DateTime(2022, 4, 3, 20, 30, 7, 391, DateTimeKind.Utc).AddTicks(7903)
                        },
                        new
                        {
                            Id = 2,
                            Content = "Content2",
                            Created = new DateTime(2022, 4, 3, 20, 30, 7, 391, DateTimeKind.Utc).AddTicks(7904),
                            TagsJson = "[]",
                            Title = "Title2",
                            Updated = new DateTime(2022, 4, 3, 20, 30, 7, 391, DateTimeKind.Utc).AddTicks(7905)
                        },
                        new
                        {
                            Id = 3,
                            Content = "Content3",
                            Created = new DateTime(2022, 4, 3, 20, 30, 7, 391, DateTimeKind.Utc).AddTicks(7905),
                            TagsJson = "[]",
                            Title = "Title3",
                            Updated = new DateTime(2022, 4, 3, 20, 30, 7, 391, DateTimeKind.Utc).AddTicks(7906)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
