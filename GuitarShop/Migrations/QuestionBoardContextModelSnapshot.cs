﻿// <auto-generated />
using GuitarShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuitarShop.Migrations
{
    [DbContext(typeof(QuestionBoardContext))]
    partial class QuestionBoardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GuitarShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "General"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("GuitarShop.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.HasIndex("TopicId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnswerText = "A general purpose object oriented language that uses a concise, Java-like syntax",
                            CategoryId = 1,
                            QuestionText = "What is C#?",
                            TopicId = 1
                        },
                        new
                        {
                            Id = 2,
                            AnswerText = "In 2002.",
                            CategoryId = 1,
                            QuestionText = "When was C# first released?",
                            TopicId = 1
                        },
                        new
                        {
                            Id = 3,
                            AnswerText = "A general purpose scripting language that executes in a web browser.",
                            CategoryId = 1,
                            QuestionText = "What is JavaScript?",
                            TopicId = 2
                        },
                        new
                        {
                            Id = 4,
                            AnswerText = "In 1995.",
                            CategoryId = 2,
                            QuestionText = "When was JavaScript first released?",
                            TopicId = 2
                        },
                        new
                        {
                            Id = 5,
                            AnswerText = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                            CategoryId = 1,
                            QuestionText = "What is Bootstrap?",
                            TopicId = 3
                        },
                        new
                        {
                            Id = 6,
                            AnswerText = "In 2011.",
                            CategoryId = 2,
                            QuestionText = "When was Bootstrap first released?",
                            TopicId = 3
                        });
                });

            modelBuilder.Entity("GuitarShop.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = 1,
                            Name = "C#"
                        },
                        new
                        {
                            TopicId = 2,
                            Name = "JavaScript"
                        },
                        new
                        {
                            TopicId = 3,
                            Name = "Bootstrap"
                        });
                });

            modelBuilder.Entity("GuitarShop.Models.Question", b =>
                {
                    b.HasOne("GuitarShop.Models.Category", "Categories")
                        .WithOne("question")
                        .HasForeignKey("GuitarShop.Models.Question", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuitarShop.Models.Topic", "Topics")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
