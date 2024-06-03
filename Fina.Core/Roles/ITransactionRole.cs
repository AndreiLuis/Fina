using Fina.Core.Models;
using Fina.Core.Requests;
using Fina.Core.Requests.Transaction;
using Fina.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Roles
{
    public interface ITransactionRole
    {
        Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest resquest);
        Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest resquest);
        Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest resquest);
        Task<Response<Transaction?>> GetByIdAsync(GetTransactionByIdResquest resquest);
        Task<PagedResponse<List<Transaction>>> GetByPeriodAsync(GetTransactionByPeriodResquest resquest);
    }
}
