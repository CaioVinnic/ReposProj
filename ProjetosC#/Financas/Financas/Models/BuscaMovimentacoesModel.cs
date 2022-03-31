using Financas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas.Models
{
    public class BuscaMovimentacoesModel
    {
        public decimal? ValorMinimo { get; set; }
        public decimal? ValorMaximo { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public Tipo? Tipo { get; set; }
        public int? UsuarioId { get; set; }
        public IList<Movimentacao> Movimentacoes { get; set; }
        public IList<Usuario> Usuarios { get; set; }
    }
}