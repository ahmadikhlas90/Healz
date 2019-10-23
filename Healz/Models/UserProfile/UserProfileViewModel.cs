using Healz.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Models.UserProfile
{
    public class UserProfileViewModel
    {
        public string ApplicationUsersID { get; set; }
        public  RegisterViewModel ApplicationUsers { get; set; }
        public int Id { get; set; }
        [Required]
        public string PhysicalAddress { get; set; }
        [Required]
        public string MailingAddress { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string Cast { get; set; }
        [Required]
        public string SufferingFrom { get; set; }
        [Required]
        public string MotherName { get; set; }
        [Required]
        public string MinitelStatus { get; set; }
        [Required]
        public string SpouseName { get; set; }
        [Required]
        public string ReligionName { get; set; }
        [Required]
        public string Occupation { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public IFormFile photo { get; set; }

    }
}
