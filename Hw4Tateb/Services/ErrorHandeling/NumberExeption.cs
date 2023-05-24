using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb.Services.ErrorHandeling
{
    public class NumberExeption :Exception
    {
        public NumberExeption() : base("Erorr : ***Please enter a number***")
        {

        }
    }
}
