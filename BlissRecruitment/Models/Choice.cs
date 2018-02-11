using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bliss.Models
{
    public class Choice
    {
        public int id { get; set; }
        public string choice { get; set; }
        public int votes { get; set; }
    }
}