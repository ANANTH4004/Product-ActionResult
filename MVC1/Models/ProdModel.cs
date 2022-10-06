using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class ProdModel
    {
        [Required]
        public int ProdID { get; set; }
        [MinLength(3,ErrorMessage ="Product Name must be Minimum 3 Character")]  
        public string ProdName { get; set; }
        [Range(0,5000,ErrorMessage ="Price Range 0 to 5000")]
        public double Price { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]   
        public DateTime MgfDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ExpDate { get; set; }

    }
}