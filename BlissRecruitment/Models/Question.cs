using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bliss.Models
{
    public class Question
    {
        public int id { get; set; }
        public string question { get; set; }
        public string image_url { get; set; }
        public string thumb_url { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime published_at { get; set; }
        public virtual List<Choice> Choices { get; set; }
        
    };
}
