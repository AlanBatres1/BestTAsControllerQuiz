using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestTAsControllerQuiz.Services
{
    public class ReverseItServices
    {
        public List<string> reversedInput = new();
        string reversed = string.Empty;
        public List<string> ReverseIt(string Input)
        {
            for (int i = Input.Length - 1; i >= 0; i--)
            {
                reversed += Input[i];
            }
            reversedInput.Add($"Your Input {Input} reversed is {reversed}");
            return reversedInput;
        }
    }
}