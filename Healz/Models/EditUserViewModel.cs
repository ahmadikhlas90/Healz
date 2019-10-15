using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Models
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {

            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string FirsName { get; set; }
        public string LastName { get; set; }


        public IList<string> Roles { get; set; }
    }
}
