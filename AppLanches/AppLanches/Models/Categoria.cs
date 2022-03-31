using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppLanches.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [StringLength(100)]
        public string CategoriaNome { get; set; }
        [StringLength(200)]
        public string Descricao { get; set; }
        public List<Lanche> Lanche { get; set; }
    }
}