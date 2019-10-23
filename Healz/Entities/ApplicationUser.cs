using Healz.Entities.BasicInfo;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Patients = new List<PatientInfo>();
        }
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddelInitial { get; set; }
        public string CNIC { get; set; }
        public virtual ICollection<PatientInfo> Patients { get; set; }
        public virtual ICollection<Physician> Physicians { get; set; }

    }
}
