using Domain.Entities;
using Domain.Interfaces;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        public CursoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
