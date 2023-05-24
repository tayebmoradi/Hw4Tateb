using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb.Services.ErrorHandeling
{
    public class PhoneNumberExeption : Exception
    {
        public PhoneNumberExeption() : base("Erorr : ***Mobile number must be 11 digits***")
        {

        }
    }
}
