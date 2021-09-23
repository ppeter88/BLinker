using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLinkerTest.BLinkerAPI
{
    public interface IBLRequest
    {
        string Send(BLConnector bLConnector);
    }
}
