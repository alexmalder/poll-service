﻿// <auto-generated />
using System;
using DotNetCrudWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DotNetCrudWebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240916142023_fix-pollid")]
    partial class fixpollid
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DotNetCrudWebApi.Models.Answer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("QuestionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("DotNetCrudWebApi.Models.Poll", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("DotNetCrudWebApi.Models.PollInstance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("PollId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("PollInstances");
                });

            modelBuilder.Entity("DotNetCrudWebApi.Models.Question", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("PollId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("DotNetCrudWebApi.Models.Answer", b =>
                {
                    b.HasOne("DotNetCrudWebApi.Models.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("DotNetCrudWebApi.Models.PollInstance", b =>
                {
                    b.HasOne("DotNetCrudWebApi.Models.Poll", "Poll")
                        .WithMany("PollInstances")
                        .HasForeignKey("PollId");

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("DotNetCrudWebApi.Models.Question", b =>
                {
                    b.HasOne("DotNetCrudWebApi.Models.Poll", null)
                        .WithMany("Questions")
                        .HasForeignKey("PollId");
                });

            modelBuilder.Entity("DotNetCrudWebApi.Models.Poll", b =>
                {
                    b.Navigation("PollInstances");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("DotNetCrudWebApi.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
