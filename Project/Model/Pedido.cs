using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Pedido
    {
        public Pedido()
        {
            this.Produtos = new List<Produto>();
        }

        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataEnc { get; set; }
        public string Obs { get; set; }
        public float TotalAPagar { get; set; }
        public string Status { get; set; }
    
    }
}
