using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Produto
    {
        public Produto()
        {
            this.Pedidos = new List<Pedido>();
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
                                              
    }
}
