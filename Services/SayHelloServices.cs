using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestTAsControllerQuiz.Services
{
    public class SayHelloServices
    {
        public string SayHello(string name){
            return $"Hello, {name} Nice to Meet You!";
        }
    }
}