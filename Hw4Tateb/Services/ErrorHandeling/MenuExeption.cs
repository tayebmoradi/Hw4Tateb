using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb.Services.ErrorHandeling
{
    public class MenuExeption : Exception
    {
        public MenuExeption() : base("Erorr : ***The number you selected does not exist in the menu***")
        {

        }

    }
}
