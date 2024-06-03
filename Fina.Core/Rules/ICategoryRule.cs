using Fina.Core.Models;
using Fina.Core.Requests.Category;
using Fina.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Rules
{
    public interface ICategoryRule
    {
        Task<Response<Category?>> CreateAsync(CreateCategoryResquest resquest);
        Task<Response<Category?>> UpdateAsync(UpdateCategoryResquest resquest);
        Task<Response<Category?>> DeleteAsync(DeleteCategoryResquest resquest);
        Task<Response<Category?>> GetByIdAsync(GetCategoryByResquest resquest);
        Task<PagedResponse<List<Category>>> GetAllAsync(GetAllCategoryResquest resquest);
    }
}
