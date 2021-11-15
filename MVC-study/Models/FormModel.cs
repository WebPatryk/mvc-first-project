using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MVC_study.Models
{
    public class FormModel
    {
        [Display(Name = "Twoje imię")]
        public string Name { get; set; }

        [Display(Name = "Data urodzenia")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:yyyy-MM-dd}")]
        public string Date { get; set; }
    }
}
