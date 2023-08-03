
using System;

namespace Regexs
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidatePincode validatePincode = new ValidatePincode();
            validatePincode.UC1_Validate("400088");
            validatePincode.UC2_Validate("D600088");
            validatePincode.UC3_Validate("400088D");
            validatePincode.UC4_Validate("400 088");
        }
    }
}
