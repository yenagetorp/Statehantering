using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StateHantering.Models.ViewModels
{
    public class SettingsCreateVM
    {
        [Display(Name = "Company name")]
        [Required]
        public string CompanyName { get; set; }

        [Display(Name = "Support e-mail address")]
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid e-mail address")]
        public string Email { get; set; }
    }
}
