using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PafoodicSeacod.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PafoodicSeacod.ViewModels
{
    public class NewsletterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name= "Email")]
        public string Email { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}
