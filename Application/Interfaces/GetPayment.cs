
using Domain.Models.Request;
namespace Application.Interfaces
{
    public abstract class IGetPayment
    {
     public abstract IEnumerable<Payment> GetAll();

    }
}
