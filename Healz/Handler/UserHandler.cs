using Healz.DatabaseConnection;
using Healz.Entities.BasicInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Handler
{
    public class UserHandler
    {
        private readonly AppDbContext context;

        public UserHandler(AppDbContext context)
        {
            this.context = context;
        }
        public PatientInfo UpdateProfile(int idToSearch, PatientInfo neighborhood)
        {
            PatientInfo found = null;
                found = context.PatientInfo.Find(idToSearch);
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
