using ProjetoKajika.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoKajika.DAO
{
    public class ProjetoContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}