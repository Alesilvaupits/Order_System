using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model;
using System.Data.Entity;

namespace Project.DAO
{
    class ProdutoDAO
    {
        private static List<Produto> produtos = new List<Produto>();

        public static Produto ObterProdutoPorId(int id)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Produtos.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public static Produto ObterProdutoPorNome(string descricao)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Produtos.FirstOrDefault(x => x.Descricao == descricao);
            }
            catch
            {
                return null;
            }
        }

        public static bool Incluir(Produto Produto)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Produtos.Add(Produto);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Alterar(Produto Produto)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(Produto).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Produto> ObterProdutos()
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Produtos.ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
