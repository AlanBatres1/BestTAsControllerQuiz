using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersServices _addTwoNumbersServices;

        public AddTwoNumbersController(AddTwoNumbersServices addTwoNumbersServices){
            _addTwoNumbersServices = addTwoNumbersServices;
        }

        [HttpGet]
        [Route("AddNumbers/{num1}/(num2)")]
        public string add2Nums(int num1, int num2){
            return _addTwoNumbersServices.add2Nums(num1, num2);
        }
    }
}