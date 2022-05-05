using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula63_Exercicio2.Servicos
{
    public class LocacaoDeCarro
    {
        public Cliente Cliente { get; set; }
        public Carro Carro{ get; set; }
        public DateTime DataIncial { get; set; }
        public DateTime DataEntrega { get; set; }
        public double ValorPorHora { get; set; }
        public TimeSpan Duracao { get; set; }
        public double ValorTotal { get; set; }


        public LocacaoDeCarro(Cliente cliente, Carro carro, DateTime dataIncial, DateTime dataEntrega, double valorPorHora)
        {
            Cliente = cliente;
            Carro = carro;
            DataIncial = dataIncial;
            DataEntrega = dataEntrega;
            ValorPorHora = valorPorHora;
        }

        public void FinalizarLocacao()
        {
            Duracao = DataEntrega.Subtract(DataIncial);
            ValorTotal = Math.Ceiling(Duracao.TotalDays) * ValorPorHora;

            /*if (Duracao.TotalHours <= 12)
            {
                ValorTotal = Math.Ceiling(Duracao.TotalHours) * ValorPorHora;
            }
            else
            {
                ValorTotal = Math.Ceiling(Duracao.TotalDays) * ValorPorDia;
            }*/
        }
    }
}
