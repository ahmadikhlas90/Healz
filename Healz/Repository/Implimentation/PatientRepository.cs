
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
                if (!string.IsNullOrEmpty(neighborhood.MailingAddress))
                {
                    found.MailingAddress = neighborhood.MailingAddress;
                }
                if (!string.IsNullOrEmpty(neighborhood.PhysicalAddress))
                {
                    found.PhysicalAddress = neighborhood.PhysicalAddress;
                }
                if (!string.IsNullOrEmpty(neighborhood.ReligionName))
                {
                    found.ReligionName = neighborhood.ReligionName;
                }
                if (!string.IsNullOrEmpty(neighborhood.SpouseName))
                {
                    found.SpouseName = neighborhood.SpouseName;
                }
                if (!string.IsNullOrEmpty(neighborhood.ZipCode))
                {
                    found.ZipCode = neighborhood.ZipCode;
                }
                if (!string.IsNullOrEmpty(neighborhood.SufferingFrom))
                {
                    found.SufferingFrom = neighborhood.SufferingFrom;
                }
                if (!string.IsNullOrEmpty(neighborhood.Occupation))
                {
                    found.Occupation = neighborhood.Occupation;
                }
                if (!string.IsNullOrEmpty(neighborhood.MinitelStatus))
                {
                    found.MinitelStatus = neighborhood.MinitelStatus;
                }  
                if (!string.IsNullOrEmpty(neighborhood.MotherName))
                {
                    found.MotherName = neighborhood.MotherName;
                }
                if (!string.IsNullOrEmpty(neighborhood.Cast))
                {
                    found.Cast = neighborhood.Cast;
                }
                if (!string.IsNullOrEmpty(neighborhood.Designation))
                {
                    found.Designation = neighborhood.Designation;
                }
                if (!string.IsNullOrEmpty(neighborhood.SufferingFrom))
                {
                    found.SufferingFrom = neighborhood.SufferingFrom;
                }
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
