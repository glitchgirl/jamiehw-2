using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarShop.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
