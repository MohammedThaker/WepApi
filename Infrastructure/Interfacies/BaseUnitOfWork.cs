using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;

namespace Infrastructure.Interfacies
{
    public class BaseUnitOfWork : IBaseUnitOftWork
    {
        protected LibraryDBContext dBContext;
        public IGetRepositoryById<Customer> Customers { get; private set; }
        public IGetRepositoryById<Payment> GetPayments { get; private set; }

        public IAddRepository<Customer> AddCustomer { get; private set; }

        public IAddRepository<Payment> AddPayment { get; private set; }
        public IAddRepository<Order> AddOrder { get; private set; }

        public BaseUnitOfWork(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
            Customers = new GetRepository<Customer>(dBContext);
            GetPayments = new GetRepository<Payment>(dBContext);
            AddCustomer = new AddRepository<Customer>(dBContext);
            AddPayment = new AddRepository<Payment>(dBContext);
            AddOrder = new AddRepository<Order>(dBContext);
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