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
        public readonly LibraryDBContext dBContext;
        public readonly IUnitOftWork unitOftWork;

        public CustomerController(LibraryDBContext dBContext, IUnitOftWork unitOftWork)
        {

            this.dBContext = dBContext;
            this.unitOftWork = unitOftWork;
        }


        [HttpGet]
        public IActionResult GetCustomers() {

            var Custpage = dBContext.Customers.ToList();

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
            // var Cust = Customers.Where(x => x.CustomerId == NewCustmoer.CustomerId).FirstOrDefault();
            // if (Cust != null) {
            //   return Conflict(new { ErrorCode = 502, ErrorMessage = "Duplicate In customer id" });
            //}

            // Customers.Add(NewCustmoer);

            dBContext.Customers.Add(NewCustmoer);
            dBContext.SaveChanges();


            return Ok(NewCustmoer);




        }







    
    [HttpPut("Id")]
    public IActionResult updateCustomer(int Id,[FromBody] Customer NewCustmoer)
    {


            // var Cust = Customers.Where(x => x.CustomerId == NewCustmoer.CustomerId).FirstOrDefault();
            // if (Cust != null) {
            //   return Conflict(new { ErrorCode = 502, ErrorMessage = "Duplicate In customer id" });
            //}

            // Customers.Add(NewCustmoer);
            var Cust = dBContext.Customers.Where(x => x.CustomerId == Id).FirstOrDefault();
            if (Cust == null)
                return NotFound(" Not found Costumer Id");
            Cust.Name = NewCustmoer.Name;
            Cust.Adress= NewCustmoer.Adress;
            Cust.Phone = NewCustmoer.Phone;
            dBContext.SaveChanges();



            return Ok(Cust);
      




    }
        [HttpDelete("Id")]
        public IActionResult updateCustomer(int Id)
        {


            // var Cust = Customers.Where(x => x.CustomerId == NewCustmoer.CustomerId).FirstOrDefault();
            // if (Cust != null) {
            //   return Conflict(new { ErrorCode = 502, ErrorMessage = "Duplicate In customer id" });
            //}

            // Customers.Add(NewCustmoer);
            var Customers = dBContext.Customers.Where(x => x.CustomerId == Id).FirstOrDefault();
            if (Customers == null)
                return NotFound(" Not found Costumer Id");
            dBContext.Customers.Remove(Customers);
            dBContext.SaveChanges();
            return Ok("Removeed") ;





        }

    }




}












