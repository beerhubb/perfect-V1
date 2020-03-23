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
        [Display(Name ="รหัสบัตรประชาชน")]
        [StringLength(14,MinimumLength = 13)]
        public string pictrue { get; set; }

        [Required]
        [Display(Name = "เบอร์โทรศัพท์")]
        public string phon { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "ID-Line")]
        public string line { get; set; }

        [Required]
        [Display(Name ="รูปโปรไฟล์")]
        public string pictrueP { get; set; }

        [Required]
        [Display(Name ="สถานะ")]
        public string status { get; set; }

        [Required]
        [Display(Name = "แม่บ้าน")]
        public string skill1 { get; set; }

        [Required]
        [Display(Name = "ทำสวน")]
        public string skill2 { get; set; }

        [Required]
        [Display(Name = "ใช้แรงงาน")]
        public string skill3 { get; set; }

        [Required]
        [Display(Name = "อื่นๆ")]
        public string skill4 { get; set; }

        //**//

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
        [Display(Name = "5 ดาว")]
        public int star5 { get; set; }
    }
}
