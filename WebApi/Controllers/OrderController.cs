
using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;
using Infrastructure.Interfacies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly IAddUnitOfWork unitOftWork;


        public OrderController(IAddUnitOfWork unitOftWork)
        {

            this.unitOftWork = unitOftWork;

        }


        [HttpGet]
        public IActionResult GetOrder()
        {
            var Custpay = unitOftWork.GetAllOrder.GetAll();

            if (Custpay == null)
                return NotFound(" Invalid Order Id");
            return Ok(Custpay);


        }



        [HttpGet("{Id}")]
        public IActionResult GetOrderById(int Id)
        {

            var Cust = unitOftWork.GetOrderById.GetByIdi(Id);
            if (Cust == null)
                return NotFound(" Invalid Order Id");
            return Ok(Cust);




        }









        [HttpPost]
        public IActionResult Setorder([FromBody] Order NewOrder)
        {

            if (String.IsNullOrEmpty(NewOrder.OrderNo))
            {
                return BadRequest(new { ErrorCode = 501, ErrorMessage = " Invalid Order name" });

            }


            unitOftWork.AddOrder.Add(NewOrder);


            unitOftWork.Complete();
         





















            return Ok(NewOrder);




        }








        [HttpPut("Id")]
        public IActionResult UpdateOrder(int Id, [FromBody] Order NewOrder)
        {


            var PaymentUpdate = unitOftWork.GetPayments.GetByIdi(Id);

            if (PaymentUpdate == null)
                return NotFound($"Movie with Id = {Id} not found");

            PaymentUpdate.PaymentTypy = NewOrder.OrderNo;


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
            var orderRemove = unitOftWork.GetOrderById.GetByIdi(Id);
            if (orderRemove == null)
                return NotFound(" Not found Order Id");
            unitOftWork.DeleteOrder.RemoveById(orderRemove);
            unitOftWork.Complete();
            return Ok("Removeed Order  ");





        }
    }
}
