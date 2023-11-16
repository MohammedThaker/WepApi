using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;

namespace Infrastructure.Interfacies
{
    public class UnitOfWork : IUnitOftWork
    {
        protected LibraryDBContext dBContext;
        public ICustomerRepository<Customer> Customers { get; private set; }
        public ICustomerRepository<Payment> Payments { get; private set; }



        public UnitOfWork(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
            Customers = new CustomerRepository<Customer>(dBContext);
            Payments = new CustomerRepository<Payment>(dBContext);
        }



        public int Complete()
        {
            return dBContext.SaveChanges();
        }

        public void Dispose()
        {
            dBContext.Dispose();
        }
    }
}