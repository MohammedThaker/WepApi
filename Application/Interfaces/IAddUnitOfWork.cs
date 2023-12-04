﻿using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAddUnitOfWork: IBaseUnitOftWork
    {
        IUpdateRepository<Customer> UpdateCustomers { get; }
        IDeleteRepository<Customer> DeleteCustomers { get; }
        IUpdateRepository<Payment> UpdatePayment { get; }

        IDeleteRepository<Payment> DeletePayments { get; }
        
        IGetRepository<Payment> GetAllPayment { get; }
       IGetRepository<Customer> GetAllCoustomer { get; }

        IGetRepository<Order> GetAllOrder { get; }
     
        IDeleteRepository<Order> DeleteOrder { get; }

        IUpdateRepository<Order> UpdateOrder { get; }
       IGetRepositoryById<Order> GetOrderById { get; }
        IPaymentByGet<Payment> IPaymentBy { get; }
        IPaydeliveryGet<PayDelivery> PayDrivary { get; }
        IPayCashGet<PaymentCash>  Paycassh { get; }
        IPaymentFactory PaymentFactory { get; }



        IPaymentByAdd<Payment> PaymentByAdd { get; }
        IPayDelivaryAdd<PayDelivery> PayByDelivaryAdd { get; }

        IPayCashAdd<PaymentCash> PayByCashAdd { get; }
        IPaymentFactoryAdd PaymentFactoryAdd { get; }




    }


}
