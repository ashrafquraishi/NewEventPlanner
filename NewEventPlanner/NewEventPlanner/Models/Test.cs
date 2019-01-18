using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewEventPlanner.Models
{
    public class Test
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Venue booked")]
        public bool Venue { get; set; }

        [DisplayName("Caterere booked")]
        public bool Caterers { get; set; }

        [DisplayName("Security agency booked")]
        public bool SecurityAgency { get; set; }

        [DisplayName("Sent Invitation")]
        public bool SendInvite { get; set; }
        [DisplayName("Chat with venue owner")]
        public bool Chat { get; set; }





    }
   
}