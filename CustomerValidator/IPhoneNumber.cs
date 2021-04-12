using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerValidator
{
    public interface IPhoneNumber
    {
        public string MobileNumber { get; protected set; }
    }
}
