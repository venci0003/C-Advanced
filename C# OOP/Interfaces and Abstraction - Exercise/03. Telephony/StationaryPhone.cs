using System;
using System.Collections.Generic;
using System.Text;
using _03._Telephony.Models.Contracts;

namespace _03._Telephony
{
    public class StationaryPhone : IDiable
    {
        public string Dial(string phoneNumber)
        {
            bool isValid = true;

            foreach (char character in phoneNumber)
            {
                if (!char.IsDigit(character))
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                return $"Dialing... {phoneNumber}";
            }
            else
            {
                return "Invalid number!";
            }
        }
    }
}
