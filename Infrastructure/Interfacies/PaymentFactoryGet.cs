using Application.Interfaces;
using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    public class PaymentFactoryGet : IPaymentFactory
    {
        
        public readonly IAddUnitOfWork unitOftWork;
        public PaymentFactoryGet(IAddUnitOfWork unitOftWork )
        {
            this.unitOftWork = unitOftWork;        
        
        }

        public void GetPaymentBay(string pay)
        {
            if (pay== "Delivary")
                unitOftWork.PayDrivary.GetAll();
           
            else if(pay=="cash")
                unitOftWork.Paycassh.GetAll();
        }
    }












}
