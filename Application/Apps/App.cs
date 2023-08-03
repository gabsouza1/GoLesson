using Application.Interfaces;
using Application.Utils;
using AutoMapper;
using Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Apps
{
    public class App<TViewModel, TModel> : IApp<TViewModel, TModel> where TModel : class where TViewModel : class
    {
        private readonly IRepository<TModel> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<App<TViewModel, TModel>> _logger;
        public App(IRepository<TModel> repository, IMapper mapper,
            ILogger<App<TViewModel, TModel>> logger) 
        { 
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public virtual async Task<TViewModel> AddAsync(TViewModel viewModel)
        {
            try 
            {
                var model = _mapper.Map<TViewModel, TModel>(viewModel);
                await _repository.Add(model);
                return viewModel;
            }
            catch(Exception ex) 
            {
                _logger.LogError(ex, "Error while adding {0}", typeof(TViewModel).Name);
                throw new AppException("An error occurred while adding the entity.", ex);
            }
        }

        public Task<IEnumerable<TViewModel>> FindAsync(Expression<Func<TModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TViewModel>> GetAllAsync()
        {
            try 
            {
                IEnumerable<TModel> models = await _repository.GetAll();
                IEnumerable<TViewModel> viewModels = _mapper.Map<IEnumerable<TViewModel>>(models);
                return viewModels;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error while creating a list of {0}", typeof(TViewModel).Name);
                throw new AppException("An error occurred while creating a list of the entity", ex);
            }
        }

        public async Task<TViewModel> GetByIdAsync(int id)
        {
            try 
            {
                TModel model = await _repository.GetById(id);
                TViewModel viewModel = _mapper.Map<TViewModel>(model);
                return viewModel;
            }
            catch(Exception ex) 
            {
                _logger.LogError(ex, "Error while finding a {0}", typeof(TViewModel).Name);
                throw new AppException("An error occurred while finding the entity.", ex);
            }
            
        }

        public async void Remove(int id)
        {
            try 
            {
                var entity = await _repository.GetById(id);
                await _repository.Delete(entity);
            }
            catch(Exception ex) 
            {
                _logger.LogError(ex, "Error while removing a {0}", typeof(TViewModel).Name);
                throw new AppException("An error occurred while removing the entity.", ex);
            }
        }

        public async Task<TViewModel> UpdateAsync(TViewModel viewModel)
        {
            try
            {
                TModel model = _mapper.Map<TModel>(viewModel);
                await _repository.Update(model);
                return viewModel;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error while updating a {0}", typeof(TViewModel).Name);
                throw new AppException("An error occurred while updating the entity.", ex);
            }
        }
    }
}
