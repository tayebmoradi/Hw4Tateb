using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string NationalCode { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string CreatedDate { get; set; }
    }
}
