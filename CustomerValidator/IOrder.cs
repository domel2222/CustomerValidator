using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerValidator
{
    public interface IOrder
    {
        int Id { get;  set; }
        decimal Price { get;  set; }
    }
}
