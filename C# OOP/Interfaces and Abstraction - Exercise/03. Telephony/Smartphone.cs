using System;
using System.Collections.Generic;
using System.Text;
using _03._Telephony.Models.Contracts;

namespace _03._Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string urlAdress)
        {
            bool isValid = true;

            foreach (char character in urlAdress)
            {
                if (char.IsDigit(character))
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                return $"Browsing: {urlAdress}!";
            }
            else
            {
                return "Invalid URL!";
            }
        }

        public string Call(string phoneNumber)
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
                return $"Calling... {phoneNumber}";
            }
            else
            {
                return "Invalid number!";
            }
        }
    }
}
