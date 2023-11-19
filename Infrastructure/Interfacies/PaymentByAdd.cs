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
    public class PaymentByAdd<T> :IPaymentByAdd<T> where T : Payment
    {
        protected LibraryDBContext dBContext;

    public PaymentByAdd(LibraryDBContext dBContext)
    {
        this.dBContext = dBContext;
    }

        public T Add(T entity)
        {
            dBContext.Set<T>().Add(entity);
            return entity;
        }

   



}
    }

