﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Compras
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataCompra { get; set; }
        public int StatusPagamentoId { get; set; }
        public int FormaPagamentoId { get; set; }


        public virtual StatusPagamento? StatusPagamento { get; set; }
        public virtual FormasPagamentos? FormaPagamento { get; set; }

    }
}
