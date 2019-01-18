using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewEventPlanner.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name = "recipient name")]
        public string FromName { get; set; }
        [Required, Display(Name = "recipient email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Message { get; set; }
    }
}