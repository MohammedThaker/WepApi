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
 


        public PaymentsController(IAddUnitOfWork unitOftWork)
        {

            this.unitOftWork = unitOftWork;
           
          
        }


        [HttpGet]
        public IActionResult GetPayments()
        {
          var pay = unitOftWork.IPaymentBy.GetAll();

            if (pay == null)
                return NotFound(" Invalid Payments Id");
            return Ok(pay);


        }



        [HttpGet("{Id}")]
        public IActionResult GetPaymentsById(int Id)
        {

            Payment? Cust = unitOftWork.GetPayments.GetByIdi(Id);
            if (Cust == null)
                return NotFound(" Invalid Payments Id");
            return Ok(Cust);




        }









        [HttpPost]
        public IActionResult SetPayments([FromBody] Payment NewPayment)
        {

            if (String.IsNullOrEmpty(NewPayment.PaymentTypy))
            {
                return BadRequest(new { ErrorCode = 501, ErrorMessage = " Invalid Payments name" });

            }


            unitOftWork.AddPayment.Add(NewPayment);


            unitOftWork.Complete();
            
          





















            return Ok(NewPayment);




        }








        [HttpPut("Id")]
        public IActionResult UpdatePayments(int Id, [FromBody] Payment NewCustmoer)
        {


            var PaymentUpdate = unitOftWork.GetPayments.GetByIdi(Id);

            if (PaymentUpdate == null)
                return NotFound($"Movie with Id = {Id} not found");

            PaymentUpdate.PaymentTypy = NewCustmoer.PaymentTypy;

           
            unitOftWork.Complete();
            return Ok(PaymentUpdate);


















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

