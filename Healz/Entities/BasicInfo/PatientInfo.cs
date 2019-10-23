using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName = "varchar(255)")]
        public string ImageUrl { get; set; }

        public string ApplicationUsersID { get; set; }
        public virtual ApplicationUser ApplicationUsers{ get; set; }
    }
}
