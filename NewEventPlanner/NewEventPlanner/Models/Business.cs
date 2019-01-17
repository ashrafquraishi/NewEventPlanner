using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewEventPlanner.Models
{
    public class Business
    {
        [Key]
        public int Id { get; set; } //venue
       
       
        [DisplayName("Venue Name")]
        public string VenueName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DisplayName("Zip Code")]
      
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        [DisplayName("Venue Name")]
        public string CaterersName { get; set; }
        public int Quantity { get; set; }

        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
        public string Customize { get; set; }
        public string Description { get; set; }
        [DisplayName("Price for these dishes")]
        public double MenuPrice { get; set; }
  
        /// security
     
        public string SecurityAgencyName { get; set; }
        [DisplayName("Number of personnal you have")]
        public int NumberOfPeople { get; set; }
        public double Charge { get; set; }
        public string ApplicationUserId { get; internal set; }
    }
}