using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApp<TViewModel, TModel> where TModel : class
        where TViewModel : class
    {
        Task<TViewModel> GetByIdAsync(int id);
        Task<IEnumerable<TViewModel>> GetAllAsync();
        Task<IEnumerable<TViewModel>> FindAsync(Expression<Func<TModel, bool>> predicate);
        Task<TViewModel> AddAsync(TViewModel viewModel);
        Task<TViewModel> UpdateAsync(TViewModel viewModel);
        void Remove(int id);
    }
}
