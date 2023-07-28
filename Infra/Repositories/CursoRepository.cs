using Domain.Entities;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class CursoRepository : Repository<Curso>
    {
        public CursoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
