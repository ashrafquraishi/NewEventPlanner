using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewEventPlanner.Models
{
    public class SecurityAgency
    {
        [Key]
        public int Id { get; set; }
        public string SecurityAgencyName { get; set; }
        [DisplayName("Number of personnal you have")]
        public int NumberOfPeople { get; set; }
        public double Charge { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}