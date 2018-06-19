using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model;

namespace Project.DAO
{
    class FuncionarioDAO
    {

        private static List<Funcionario> funcionarios = new List<Funcionario>();

        public static Funcionario ObterFuncionarioPorCpf(string cpf)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Funcionarios.FirstOrDefault(x => x.Cpf == cpf);
            }
            catch
            {
                return null;
            }
        }

        public static Funcionario ObterFuncionarioPorId(int id)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Funcionarios.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }
        public static bool Incluir(Funcionario funcionario)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Alterar(Funcionario Funcionario)
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(Funcionario).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List <Funcionario> ObterFuncionarios()
        {
            ProjectRegister db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Funcionarios.ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}

