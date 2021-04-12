using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerValidator
{
    public interface ICusnew 
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public int PercentageDiscount { get;  set; }

        public IPhoneNumber PhoneNumber { get;  set; }

        List<IOrder> Orders { get;  set; }

        public int GetAge();
    }
}
