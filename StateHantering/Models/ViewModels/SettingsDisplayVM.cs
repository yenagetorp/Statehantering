using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StateHantering.Models.ViewModels
{
    public class SettingsDisplayVM
    {
        [Display(Name = "Company name")]
        public string CompanyName { get; set; }

        [Display(Name = "Support e-mail address")]
        public string Email { get; set; }
        public string Temp { get; set; }
    }
}
