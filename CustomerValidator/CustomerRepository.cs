using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerValidator
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<ICusnew> _allCustomers;

        private readonly ICustomerValidator _customerValidator;

        private CustomerVal _customerValidator2;
        public int MartinJones { get; protected set; }

        public IReadOnlyList<ICusnew> AllCustomers => _allCustomers.AsReadOnly();

        public CustomerRepository(ICustomerValidator customerValidator , CustomerVal customerVal)
        {

            _allCustomers = new List<ICusnew>();
            MartinJones = 60;
            _customerValidator = customerValidator;
            _customerValidator2 = customerVal;

        }

        public bool Add(ICusnew customer)
        {

            if (_customerValidator2.Validate(customer))
            //if(customer.FirstName != null)
            {

                _allCustomers.Add(customer);
                return true;
            }
            return false;
        }
    }
}
