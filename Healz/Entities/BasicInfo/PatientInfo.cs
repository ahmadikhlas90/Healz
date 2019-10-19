using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Entities.BasicInfo
{
    public class PatientInfo
    {
        public int Id { get; set; }
       
        public string PhysicalAddress { get; set; }
        public string MailingAddress { get; set; }
        public string ZipCode { get; set; }
        public string Cast { get; set; }
        public string SufferingFrom { get; set; }
        public string MotherName { get; set; }
        public string MinitelStatus { get; set; }
        public string SpouseName { get; set; }
        public string ReligionName { get; set; }
        public string Occupation { get; set; }
        public string Designation { get; set; }
        [Required]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
