using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;
using Infrastructure.Interfacies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/Customer/Payments")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {      
        public readonly IAddUnitOfWork unitOftWork;
        public readonly IPaymentFactory PaymentFactory;



        public PaymentsController(IAddUnitOfWork unitOftWork, IPaymentFactory PaymentFactory)
        {

            this.unitOftWork = unitOftWork;
           this.PaymentFactory = PaymentFactory;
          
        }


        [HttpGet]
        public IActionResult GetPayments()
        {
           

            var Cust = unitOftWork.IPaymentBy.GetAll();
            if (Cust == null)
                return NotFound(" Invalid Payments");
            return Ok(Cust);
            

        }


        [HttpGet("Type")]
        public IActionResult GetPay(string type)
        {

          
            if (type == null)
                return NotFound(" Invalid Payments");
            else if (type.ToLower() == "delivary")
            {
                var paydel = unitOftWork.PayDrivary.GetAll();
                return Ok(paydel);
            }
            else if (type.ToLower()== "cash")
            {  var payash = unitOftWork.Paycassh.GetAll();
            return Ok(payash); }
            else 
                return NotFound(" Invalid Payments");


        }

        [HttpGet("{Id}")]
        public IActionResult GetPaymentsById(int Id)
        {

          
            Payment? Cust = unitOftWork.GetPayments.GetByIdi(Id);

            if (Cust == null)
                return NotFound(" Invalid Payments Id");
         
            return Ok(Cust);




        }







        [HttpPost("ByDelivary")]
        public IActionResult SetPayDelivary([FromBody] PayDelivery ByDelivary)
        {

            /* if (String.IsNullOrEmpty(NewPayment.PaymentTypy))
             {
                 return BadRequest(new { ErrorCode = 501, ErrorMessage = " Invalid Payments name" });

             }*/
         
         if(ByDelivary == null)   
            unitOftWork.PayByDelivaryAdd.Add(ByDelivary);
            unitOftWork.Complete();
            return Ok(ByDelivary);




        }
        [HttpPost("PayCash")]
        public IActionResult SetPayCash([FromBody] PaymentCash PayCash)
        {

            /* if (String.IsNullOrEmpty(NewPayment.PaymentTypy))
             {
                 return BadRequest(new { ErrorCode = 501, ErrorMessage = " Invalid Payments name" });

             }*/


            unitOftWork.PayByCashAdd.Add(PayCash);
            unitOftWork.Complete();
            return Ok(PayCash);




        }







      
        [HttpDelete("Id")]
        public IActionResult RemoveById(int Id)
        {


            // var Cust = Customers.Where(x => x.CustomerId == NewCustmoer.CustomerId).FirstOrDefault();
            // if (Cust != null) {
            //   return Conflict(new { ErrorCode = 502, ErrorMessage = "Duplicate In customer id" });
            //}RemoveById

            // Customers.Add(NewCustmoer);
            var PayRemove = unitOftWork.GetPayments.GetByIdi(Id);
            if (PayRemove == null)
                return NotFound(" Not found Costumer Id");
            unitOftWork.DeletePayments.RemoveById(PayRemove);
            unitOftWork.Complete();
            return Ok("Removeed");





        }

    }








}

