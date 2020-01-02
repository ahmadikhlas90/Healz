
using Healz.DatabaseConnection;
using Healz.Entities.BasicInfo;
using Healz.Repository.Implimentation;
using Healz.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heaz.Repository.Implimentation
{
    public class PatientRepository : Repository<PatientInfo>, IPateintInfoRepository
    {
        private readonly AppDbContext context;

        public PatientRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public PatientInfo UpdateProfile(string idToSearch, PatientInfo neighborhood)
        {

            PatientInfo found = null;
            found = (from p in context.PatientInfo
                     where p.ApplicationUsersID == idToSearch
                     select p).FirstOrDefault();
            if (!string.IsNullOrEmpty(neighborhood.ApplicationUsersID))
            {
                found.MailingAddress = neighborhood.MailingAddress;
                found.PhysicalAddress = neighborhood.PhysicalAddress;
                found.ReligionName = neighborhood.ReligionName;
                found.SpouseName = neighborhood.SpouseName;
                found.ZipCode = neighborhood.ZipCode;
                found.SufferingFrom = neighborhood.SufferingFrom;
                found.Occupation = neighborhood.Occupation;
                found.MinitelStatus = neighborhood.MinitelStatus;
                found.MotherName = neighborhood.MotherName;
                found.Cast = neighborhood.Cast;
                found.Designation = neighborhood.Designation;
                found.SufferingFrom = neighborhood.SufferingFrom;
            }

            if (neighborhood.ImageUrl != null)
            {
                found.ImageUrl = neighborhood.ImageUrl;
            }
            //context.Entry(found.City).State = EntityState.Unchanged;
            context.SaveChanges();

            return neighborhood;
        }
    }
   

  
}
