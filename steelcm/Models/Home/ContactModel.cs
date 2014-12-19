using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace steelcm.Models.Home
{
    public class ContactModel
    {
        [DisplayName("Your name")]
        [MaxLength(70, ErrorMessage = "This value is too long (max length 70 characters)")]
        [Required(ErrorMessage = "This value is required")]
        public string Name { get; set; }
        
        [DisplayName("Email address")]
        [EmailAddress(ErrorMessage = "This value is not a valid email address")]
        [MaxLength(255, ErrorMessage = "This value is too long (max length 255 characters)")]
        [Required(ErrorMessage = "This value is required")]
        public string Email { get; set; }

        [DisplayName("Company")]
        [MaxLength(255, ErrorMessage = "This value is too long (max length 255 characters)")]
        public string Company { get; set; }

        [DisplayName("Phone number")]
        [MaxLength(35, ErrorMessage = "This value is too long (max length 35 characters)")]
        [Phone(ErrorMessage = "This value is not a valid phone number")]
        public string Phone { get; set; }

        [DisplayName("How can I help?")]
        [MaxLength(32768, ErrorMessage = "This value is too long")]
        [Required(ErrorMessage = "This value is required")]
        public string Message { get; set; }

        public bool? TestProp { get; set; }
    }
}