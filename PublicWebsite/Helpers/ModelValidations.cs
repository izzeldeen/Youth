using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWebsite.Helpers
{
    public class ModelValidations
    {
        public bool IsValid(object validateData)
        {
            return validateData.GetType().GetProperties().All(p => p.GetValue(validateData) != null);
        }

        public bool IsObjectNull(object validateData)
        {
            if (validateData == null)
                return true;

            return false;
        }
    }
}
