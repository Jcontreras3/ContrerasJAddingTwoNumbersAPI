//Jovann Contreras
//Date 10/25/2022
//Peer reviewed by: Freddy Aguilar - The program takes their mini challenge 2 and converts it to API format. It takes two number inputs from the user and adds them together, outputting them onto Postman. It works as intended and the code looks clean. Good job!


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContrerasJAddingTwoNumbersAPI.Controllers
{
    [Route("[controller]")]
    public class AddingController : Controller
    {
        [HttpGet]
        [Route("Add/{num1}/{num2}")]

        public int AddingNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}