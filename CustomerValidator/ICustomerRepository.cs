using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerValidator
{
    public interface ICustomerRepository
    {
        public IReadOnlyList<ICusnew> AllCustomers { get;  }

        public int MartinJones { get;   }
        public bool Add(ICusnew customer);
    }
}
