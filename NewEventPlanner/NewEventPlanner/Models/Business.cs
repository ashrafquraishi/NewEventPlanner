﻿using System;
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
        public int Capacity { get; set; }
        public double Price { get; set; }
        public string ApplicationUserId { get; internal set; }
    }
}