using System;
using System.Collections.Generic;
using System.Text;

namespace Mips16bits
{
    public class Validator
    {
       public void checkValue(string value, string value1, string value2)
        {
            if (Convert.ToInt64(value, 16) > 32 || Convert.ToInt64(value1, 16) > 32 || Convert.ToInt64(value2, 16) > 32 )
            {
                throw new  Exception("The value is not valid");
                    
            }

        }
    }
}
