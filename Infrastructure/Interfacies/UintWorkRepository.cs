using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    internal interface UintWorkRepository:IDisposable
    {
        ICustomerRepository ICustomerRepository { get; }
        int Save();
    }
}
