﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hw4Tateb.Services.Validation
{
    public static class ValidationPhone
    {
        public static bool IsValidPhoneNumber(string Phone)
        {
            try
            {
                if (string.IsNullOrEmpty(Phone))
                    return false;
                var r = new Regex(@"^(?:0|98|\+98|\+980|0098|098|00980)?(9\d{9})$");
                return r.IsMatch(Phone);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
