using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;

namespace Infrastructure.Interfacies
{
    public class PayDrivary : PaymentBy, IPayDrivary
    {
        public PayDrivary(LibraryDBContext dBContext) : base(dBContext)
        {
        }

       
    }

}
