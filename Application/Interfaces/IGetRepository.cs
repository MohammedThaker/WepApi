
using Domain.Models.Request;
namespace Application.Interfaces
{
    public  interface IGetRepository<T> where T : class
    {

        public IEnumerable<T> GetAll();

    }
}
