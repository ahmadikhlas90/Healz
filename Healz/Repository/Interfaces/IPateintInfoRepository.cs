using Healz.Entities.BasicInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Repository.Interfaces
{
    public interface IPateintInfoRepository : IRepository<PatientInfo>
    {

        PatientInfo UpdateProfile(string idToSearch, PatientInfo neighborhood);
    }
  
}
