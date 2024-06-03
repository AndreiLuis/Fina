using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests.Transaction
{
    public class GetTransactionByIdResquest : Resquest
    {
        public long Id { get; set; }
    }
}
