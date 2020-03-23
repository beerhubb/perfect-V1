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
        [Display(Name ="ผู้ให้คะแนน")]
        public string namesesid { get; set; }

        [Required]
        [Display(Name = "ความพึงพอใจ")]
        public string star { get; set; }

        [Required]
        [Display(Name ="แสดงความคิดเห็น")]
        [StringLength(250)]
        public string comment { get; set; }
    }
}
