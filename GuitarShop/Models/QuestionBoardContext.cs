using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarShop.Models
{
    public class QuestionBoardContext : DbContext
    {

        public QuestionBoardContext(DbContextOptions<QuestionBoardContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId=1, Name = "General" },
                new Category { CategoryId=2, Name = "History" }
            );
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = 1, Name = "C#" },
                new Topic { TopicId = 2, Name = "JavaScript" },
                new Topic { TopicId = 3, Name = "Bootstrap" }
            ); ;
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    AnswerText = "A general purpose object oriented language that uses a concise, Java-like syntax",
                    QuestionText = "What is C#?",
                    TopicId = 1,
                    CategoryId =1
                },
                new Question
                {
                    Id = 2,
                    AnswerText = "In 2002.",
                    QuestionText = "When was C# first released?",
                    TopicId = 1,
                    CategoryId =1
                },
                new Question
                {
                    Id = 3,
                    AnswerText = "A general purpose scripting language that executes in a web browser.",
                    QuestionText = "What is JavaScript?",
                    TopicId = 2,
                    CategoryId =1
                },
                new Question
                {
                    Id = 4,
                    AnswerText = "In 1995.",
                    QuestionText = "When was JavaScript first released?",
                    TopicId = 2,
                    CategoryId = 2
                },
                new Question
                {
                    Id = 5,
                    AnswerText = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                    QuestionText = "What is Bootstrap?",
                    TopicId = 3,
                    CategoryId = 1
                },
                new Question
                {
                    Id = 6,
                    AnswerText = "In 2011.",
                    QuestionText = "When was Bootstrap first released?",
                    TopicId = 3,
                    CategoryId =2
                }
            );
        }


    }
}
