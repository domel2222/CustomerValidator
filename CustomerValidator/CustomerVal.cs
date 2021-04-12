using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerValidator
{
    public class CustomerVal : ICustomerValidator
    {

        private int _minimumAge = 18;

        //public bool Validate (ICustomer customer)  first
        //{
        //    if (customer == null) throw new ArgumentNullException();

        //    else if (customer.GetAge() < _minimumAge) return false;

        //    return true;
        //}


        public bool Validate(ICusnew customer)
        {
            if (customer == null) throw new ArgumentNullException();

            else if (customer.GetAge() < _minimumAge) return false;

            return true;
        }
    }

}
