using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dynamic_Disposal.Models
{
    public class PickUpDay
    {
        [Key]
        public int DayID { get; set; }
        public string DayValue { get; set; }
    }
}