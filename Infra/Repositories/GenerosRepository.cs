using Domain.Entities;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class GenerosRepository : Repository<Genero>
    {
        public GenerosRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
