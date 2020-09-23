using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Utility
{
    public interface ITransactionManager
    {
        string GetTransaction();
    }
}
