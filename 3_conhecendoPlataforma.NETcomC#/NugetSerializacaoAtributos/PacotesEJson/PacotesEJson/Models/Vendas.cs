using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacotesEJson.Models
{
    class Vendas
    {
        //construtor
        public Vendas(int id, string produto, decimal preco, string nomeVendedor, DateTime datavendas)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            Namevendedor = nomeVendedor;
            DataVendas = datavendas;
        }



        //propriedades
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public string Namevendedor  { get; set; }
        public DateTime DataVendas { get; set; }


    }
}
