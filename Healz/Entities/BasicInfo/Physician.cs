using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Entities.BasicInfo
{
    public class Physician
    {
        public int Id { get; set; }

        public string ProfessionlStatement { get; set; }
        public string PracticingFrom { get; set; }
        public string PostalAddress { get; set; }
        public string MinitelStatus { get; set; }
        public string SpouseName { get; set; }

        public string ApplicationUsersID { get; set; }
        public virtual ApplicationUser ApplicationUsers { get; set; }
    }
}
