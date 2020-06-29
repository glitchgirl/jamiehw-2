using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarShop.Models
{
    public class Topic
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TopicId { get; set; }
        public string Name { get; set; }
    }
}
