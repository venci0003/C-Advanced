using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Telephony.Models.Contracts
{
    public interface IDiable
    {
        string Dial(string phoneNumber);
    }
}
