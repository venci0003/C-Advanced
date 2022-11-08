using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Hierarchy.Models.Contracts
{
    public interface IAddRemoveCollection : IAddCollection
    {
        string Remove();
    }
}
