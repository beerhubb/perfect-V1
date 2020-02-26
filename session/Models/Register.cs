using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace session.Models
{
    public class Register
    {
        [BsonId]
        public string _id { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string username { get; set; }

        [Required]
        [Display(Name = "PassWord")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Display(Name ="ชื่อ-นามสกุล")]
        public string name { get; set; }

        [Required]
        [Display(Name ="อายุ")]
        public string age { get; set; }

        [Required]
        [Display(Name ="ที่อยู่ที่ติดต่อได้")]
        public string address { get; set; }

        [Required]
        [Display(Name ="รูปบัตรประชาชน")]
        public string pictrue { get; set; }

        [Required]
        [Display(Name ="รูปโปรไฟล์")]
        public string pictrueP { get; set; }

        [Required]
        [Display(Name ="สถานะ")]
        public string status { get; set; }
    }
}
