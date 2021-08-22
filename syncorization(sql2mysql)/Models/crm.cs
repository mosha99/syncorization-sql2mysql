using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataEditor.Models
{
    public class crm
    {
        public int Id { get;  set; }

        [Display(Name ="نام")]
        [Required(ErrorMessage ="این فیلد اجباری است")]
        public string Name { get; set; }


        [Display(Name ="شماره تلفن")]
        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MaxLength(11,ErrorMessage ="شماره معتبر وارد نمایید")]
        [MinLength(11,ErrorMessage = "شماره معتبر وارد نمایید")]
        [RegularExpression("^([0-9۰-۹]){11}$", ErrorMessage = "شماره معتبر وارد نمایید")]
        public string Number { get; set; }


        [Display(Name ="کدملی")]
        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MaxLength(10, ErrorMessage = "کد ملی معتبر وارد نمایید")]
        [MinLength(10, ErrorMessage = "کد ملی معتبر وارد نمایید")]
        [RegularExpression("^([0-9۰-۹]){10}$", ErrorMessage ="کد ملی معتبر وارد نمایید")]
        public string NationalCode { get; set; }
    }
}