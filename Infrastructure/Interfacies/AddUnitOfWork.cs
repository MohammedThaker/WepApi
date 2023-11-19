using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    public class AddUnitOfWork : BaseUnitOfWork ,IAddUnitOfWork

    {
      
        public IUpdateRepository<Customer> UpdateCustomers { get;private set; }
        public IDeleteRepository<Customer> DeleteCustomers { get;private set; }

        public IUpdateRepository<Payment> UpdatePayment { get; private set; }
        public IDeleteRepository<Payment> DeletePayments { get; private set; }

        public IGetRepository<Payment> GetAllPayment { get; private set; }
        public IGetRepository<Customer> GetAllCoustomer { get; private set; }

        public IGetRepository<Order> GetAllOrder { get; private set; }
        public IDeleteRepository<Order> DeleteOrder { get; private set; }
        public IUpdateRepository<Order> UpdateOrder { get; private set; }
        public IGetRepositoryById<Order> GetOrderById { get; private set; }

      

        public IPaymentFactory PaymentFactory { get; private set; }

      public IPaymentByGet<Payment> IPaymentBy { get; private set; }

        public IPaydeliveryGet<PayDelivery> PayDrivary { get; private set; }

         public IPayCashGet<PaymentCash> Paycassh { get; private set; }

        public IPaymentByAdd<Payment> PaymentByAdd { get; private set; }

        public IPayDelivaryAdd<PayDelivery> PayByDelivaryAdd { get; private set; }

    public IPayCashAdd<PaymentCash> PayByCashAdd { get; private set; }

        public IPaymentFactoryAdd PaymentFactoryAdd { get; private set; }

        public AddUnitOfWork(LibraryDBContext dBContext) : base(dBContext)

        {
            UpdateCustomers = new UpdateRepository<Customer>(dBContext);

            DeleteCustomers = new DeleteRepository<Customer>(dBContext);
            UpdatePayment = new UpdateRepository<Payment>(dBContext);
            DeletePayments = new DeleteRepository<Payment>(dBContext);
            GetAllPayment = new GetAllRepository<Payment>(dBContext);
            GetAllCoustomer = new GetAllRepository<Customer>(dBContext);
            GetOrderById=new GetRepository<Order>(dBContext);
            GetAllOrder = new GetAllRepository<Order>(dBContext);
            UpdateOrder = new UpdateRepository<Order>(dBContext);
            DeleteOrder = new DeleteRepository<Order>(dBContext);
            IPaymentBy = new PaymentByGet<Payment>(dBContext);
            PayDrivary = new PayDrivary<PayDelivery>(dBContext);
            Paycassh = new PayCashGet<PaymentCash>(dBContext);
            PaymentByAdd = new PaymentByAdd<Payment>(dBContext);
            PayByDelivaryAdd = new PayDelivaryAdd<PayDelivery>(dBContext);
            PayByCashAdd = new PayCashAdd<PaymentCash>(dBContext);

        }

     
    }
}
