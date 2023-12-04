using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;

namespace Infrastructure.Interfacies
{
    public class PayDrivary<T> : PaymentByGet<T>, IPaydeliveryGet<T> where T : PayDelivery
    {
    
    
        public PayDrivary(LibraryDBContext dBContext) : base(dBContext)
        {
        }

       

    }

}
  