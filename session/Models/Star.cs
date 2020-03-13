using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace session.Models
{
    public class Star
    {
        [BsonId]
        public string _id { get; set; }

        [Required]
        public string Sesid { get; set; }

        [Required]
        public string Maidid { get; set; }

        [Required]
        [Display(Name = "1 ดาว")]
        public int star1 { get; set; }

        [Required]
        [Display(Name = "2 ดาว")]
        public int star2 { get; set; }

        [Required]
        [Display(Name = "3 ดาว")]
        public int star3 { get; set; }

        [Required]
        [Display(Name = "4 ดาว")]
        public int star4 { get; set; }
        
        [Required]
        [Display(Name ="5 ดาว")]
        public int star5 { get; set; }

        public string status { get; set; }
    }
}
