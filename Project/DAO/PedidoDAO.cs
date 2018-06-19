using Project.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    class PedidoDAO
    {
        private static List<Pedido> pedidos = new List<Pedido>();

        public static Pedido ObterPedidoPorId(int id)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Pedidos.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public static bool Incluir(Pedido Pedido)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Pedidos.Add(Pedido);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Alterar(Pedido Pedido)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(Pedido).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Excluir(Pedido Pedido)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Pedidos.Remove(Pedido);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<Pedido> ObterPedidos()
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Pedidos.ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}

