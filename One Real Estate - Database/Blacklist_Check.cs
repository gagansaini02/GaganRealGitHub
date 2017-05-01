using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace One_Real_Estate___Database
{
    public class Blacklist_Check
    {
        public bool blacklistCheck(String userInput)
        {
            var regularExpression = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9]*$");
            if (regularExpression.IsMatch(userInput))
            {
                return true;
            }
            else
            {
                return false;
            }

        }




    }
}