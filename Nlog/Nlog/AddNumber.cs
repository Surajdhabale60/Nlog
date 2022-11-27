using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProject
{
    public class AddNumber
    {
        private readonly Nlog nLog = new Nlog();
        public int Sum(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                nLog.LogDebug("Debug Successfull : Sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("SecondNumber or secondNumber should not equal to 0");
            }
            int result = secondNumber + secondNumber;
            nLog.LogDebug("Debug Successfull : Sum()");
            nLog.LogInfo("Sum method passed, Result" + result);
            return result;
        }
    }
}
