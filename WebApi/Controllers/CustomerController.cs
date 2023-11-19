using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;
using Infrastructure.Interfacies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly IAddUnitOfWork unitOftWork;

        public CustomerController( IAddUnitOfWork unitOftWork)
        {

            this.unitOftWork = unitOftWork;
        }


        [HttpGet]
        public IActionResult GetCustomers() {

            var Custpage = unitOftWork.GetAllCoustomer.GetAll();

            return Ok(Custpage);

        }



        [HttpGet("{Id}")]
        public IActionResult GetCus(int Id)
        {

            var Cust = unitOftWork.Customers.GetByIdi(Id);
            if (Cust == null)
                return NotFound(" Invalid Costumer Id");
            return Ok(Cust);




        }
      



        




        [HttpPost]
        public IActionResult SetCustomer([FromBody] Customer NewCustmoer)
        {

            if (String.IsNullOrEmpty(NewCustmoer.Name))
            {
                return BadRequest(new { ErrorCode = 501, ErrorMessage = " Invalid Costumer name" });

            }


            unitOftWork.AddCustomer.Add(NewCustmoer);


            unitOftWork.Complete();
            return Ok(NewCustmoer);




        }







    
    [HttpPut("Id")]
    public IActionResult UpdateCustomer(int Id,[FromBody] Customer NewCustmoer)
    {


            var CutsUpdate = unitOftWork.Customers.GetByIdi(Id);

            if (CutsUpdate == null)
                return NotFound($"Movie with Id = {Id} not found");

            CutsUpdate.Name =  NewCustmoer.Name;
            CutsUpdate.Adress = NewCustmoer.Adress;
            CutsUpdate.Phone = NewCustmoer.Phone;
            CutsUpdate.Created = DateTime.Now;
            unitOftWork.UpdateCustomers.Update(CutsUpdate);
            unitOftWork.Complete();
            return Ok(CutsUpdate);


















        }
        [HttpDelete("Id")]
        public IActionResult RemoveById(int Id)
        {


            // var Cust = Customers.Where(x => x.CustomerId == NewCustmoer.CustomerId).FirstOrDefault();
            // if (Cust != null) {
            //   return Conflict(new { ErrorCode = 502, ErrorMessage = "Duplicate In customer id" });
            //}RemoveById

            // Customers.Add(NewCustmoer);
            var CutsRemove = unitOftWork.Customers.GetByIdi(Id);
            if (CutsRemove == null)
                return NotFound(" Not found Costumer Id");
           unitOftWork.DeleteCustomers.RemoveById(CutsRemove);
            unitOftWork.Complete();
            return Ok("Removeed") ;





        }

    }




}












