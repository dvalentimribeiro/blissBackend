using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bliss.ViewModels
{
    public class DtoShare
    {
        [Required]
        [EmailAddress(ErrorMessage = "Not a valid email")]
        public string destination_email { get; set; }
        [Required]
        public string content_url { get; set; }
    }
}
