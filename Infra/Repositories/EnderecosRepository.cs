using Domain.Entities;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class EnderecosRepository : Repository<Enderecos>
    {
        public EnderecosRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
