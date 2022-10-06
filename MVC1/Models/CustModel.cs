using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class CustModel
    {
        [Required]
        public int CustID { get; set; }
        [MaxLength(20,ErrorMessage ="Maximum 20 Character only")]
        public string CustName { get; set; }
        public string City { get; set; }
    }
}