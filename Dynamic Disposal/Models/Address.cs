using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dynamic_Disposal.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        [ForeignKey("User")]
        public string UserID { get; set; }
        public ApplicationUser User { get; set; }
        [ForeignKey("PickUpDay")]
        public int PickUpDayID { get; set; }
        public PickUpDay PickUpDay { get; set; }
    }
}