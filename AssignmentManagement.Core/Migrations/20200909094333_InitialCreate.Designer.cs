﻿// <auto-generated />
using System;
using AssignmentManagement.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssignmentManagement.Core.Migrations
{
    [DbContext(typeof(AssignmentDbContext))]
    [Migration("20200909094333_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssignmentManagement.Core.Domain.GroupAssignment", b =>
                {
                    b.Property<string>("ProblemId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("SubmissionDeadline")
                        .HasColumnType("datetime2");

                    b.HasKey("ProblemId", "GroupId");

                    b.ToTable("GroupAssignment");
                });
#pragma warning restore 612, 618
        }
    }
}