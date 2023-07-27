using Domain.Entities;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class AulasRepository : Repository<Aula>
    {
        public AulasRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
