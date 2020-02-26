﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace session.Models
{
    public class Jregister
    {
        [BsonId]
        public string _id { get; set; }

        [Required]
        [Display(Name = "ชื่องาน")]
        public string jname { get; set; }

        [Required]
        [Display(Name = "รูปที่ 1")]
        public string jpictrue1 { get; set; }

        [Required]
        [Display(Name = "รูปที่ 2")]
        public string jpictrue2 { get; set; }

        [Required]
        [Display(Name = "รูปที่ 3")]
        public string jpictrue3 { get; set; }

        [Required]
        [Display(Name = "รายละเอียด")]
        public string jdatail { get; set; }

        [Required]
        [Display(Name = "ที่อยู่สถานที่")]
        public string jaddress { get; set; }

        [Required]
        [Display(Name = "ราคา")]
        public string jprice { get; set; }

        [Required]
        [Display(Name = "Line ID")]
        public string jline { get; set; }

        [Required]
        [Display(Name = "เบอร์โทรศัพท์")]
        public string jphone { get; set; }

        public string jid { get; set; }

    }
}
