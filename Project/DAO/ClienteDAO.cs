using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model;
using System.Data.Entity;

namespace Project.DAO
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static Cliente ObterClientePorId(int id)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Clientes.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }


        public static Cliente ObterClientePorCpf(string cpf)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Clientes.FirstOrDefault(x => x.Cpf == cpf);
            }
            catch
            {
                return null;
            }
        }

        public static bool Incluir(Cliente Cliente)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Clientes.Add(Cliente);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Alterar(Cliente Cliente)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(Cliente).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List <Cliente> ObterClientes()
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Clientes.ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}

