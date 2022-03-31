using ProjetoKajika.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoKajika.DAO
{
    public class UsuarioDAO
    {
        private ProjetoContext context;

        public UsuarioDAO(ProjetoContext context)
        {
            this.context = context;
        }

        public void Adiciona(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();

        }

        public IList<Usuario> Lista()
        {
            return context.Usuarios.ToList();
        }
     }
}