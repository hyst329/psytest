﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using psytest.Models;

namespace psytest.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20190119161659_SetAutoIncrement")]
    partial class SetAutoIncrement
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("psytest.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Part")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(1);

                    b.Property<int>("TestId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.HasIndex("TypeId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("psytest.Models.QuestionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("QuestionType");
                });

            modelBuilder.Entity("psytest.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Instruction");

                    b.Property<string>("MetricsComputeScript");

                    b.Property<string>("MetricsDescriptions");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("psytest.Models.AntagonisticQuestionType", b =>
                {
                    b.HasBaseType("psytest.Models.QuestionType");

                    b.Property<int>("MaxValue");

                    b.Property<int>("MinValue");

                    b.HasDiscriminator().HasValue("AntagonisticQuestionType");
                });

            modelBuilder.Entity("psytest.Models.SliderQuestionType", b =>
                {
                    b.HasBaseType("psytest.Models.QuestionType");

                    b.Property<int>("MaxValue")
                        .HasColumnName("SliderQuestionType_MaxValue");

                    b.Property<int>("MinValue")
                        .HasColumnName("SliderQuestionType_MinValue");

                    b.HasDiscriminator().HasValue("SliderQuestionType");
                });

            modelBuilder.Entity("psytest.Models.VariantQuestionType", b =>
                {
                    b.HasBaseType("psytest.Models.QuestionType");

                    b.Property<string>("Variants");

                    b.HasDiscriminator().HasValue("VariantQuestionType");
                });

            modelBuilder.Entity("psytest.Models.Question", b =>
                {
                    b.HasOne("psytest.Models.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("psytest.Models.QuestionType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
