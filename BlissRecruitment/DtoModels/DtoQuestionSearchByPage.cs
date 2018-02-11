using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bliss.DtoModels
{
    public class DtoQuestionSearchByPage
    {
        [Required]
        public int limit { get; set; }

        [Required]
        public int offset { get; set; }

        public string filter { get; set; }
    }
}