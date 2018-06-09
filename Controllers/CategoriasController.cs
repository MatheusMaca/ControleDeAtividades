using Controllers.Base;
using Controllers.DAL;
using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class CategoriasController : IBaseController<Categoria>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Categoria entity)
        {
            contexto.Categorias.Add(entity);
            contexto.SaveChanges();
        }

        public Categoria BuscarPorID(int id)
        {
            return contexto.Categorias.Find(id);
        }

        public void Editar(Categoria entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Categoria categoria = BuscarPorID(id);

            if (categoria != null)
            {
                contexto.Categorias.Remove(categoria);
                contexto.SaveChanges();
            }
        }

        public IList<Categoria> ListarPorNome(string nome)
        {
            return contexto.Categorias.Where(x => x.Nome == nome).ToList();
        }

        public IList<Categoria> ListarTodos()
        {
            return contexto.Categorias.ToList();
        }
    }
}
