using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace session.Models
{
    public class Confirmed
    {
        [BsonId]
        public string _id { get; set; }

        [Required]
        public string Jid { get; set; }

        [Required]
        public string JUSEid { get; set; }

        [Required]
        public string Mid { get; set; }

        [Required]
        [Display(Name ="ชื่องาน")]
        public string NJ { get; set; }
        
        [Required]
        [Display(Name ="ชื่อเจ้าของงาน")]
        public string NM { get; set; }

        [Required]
        [Display(Name ="สถานะ")]
        public string status { get; set; }
    }
}
