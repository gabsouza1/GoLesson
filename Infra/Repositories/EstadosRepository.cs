using Domain.Entities;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class EstadosRepository : Repository<Estados>
    {
        public EstadosRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
