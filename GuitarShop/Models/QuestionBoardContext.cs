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

            Category general = new Category { CategoryId = 1, Name = "General" };
            Category history = new Category { CategoryId = 2, Name = "History" };

            Topic cSharp = new Topic { TopicId = 1, Name = "C#" };
            Topic javaScript = new Topic { TopicId = 2, Name = "JavaScript" };
            Topic bootStrap = new Topic { TopicId = 3, Name = "Bootstrap" };

            modelBuilder.Entity<Category>().HasData(general, history);
            modelBuilder.Entity<Topic>().HasData(cSharp, javaScript, bootStrap); ;

            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    AnswerText = "A general purpose object oriented language that uses a concise, Java-like syntax",
                    QuestionText = "What is C#?",
                    TopicId = 1,
                    CategoryId =1
                }
            );
        }


    }
}
