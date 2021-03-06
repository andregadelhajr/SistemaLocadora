using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula63_Exercicio2.Servicos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public long CPF { get; set; }

        public Cliente(string nome, long cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public override string ToString()
        {
            return Nome + " - CPF: " + CPF;
        }
    }

    public class ClienteRepository
    {
        public static List<Cliente> InitializeCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente("Andre", 44444444444));
            clientes.Add(new Cliente("Renata", 11111111111));
            clientes.Add(new Cliente("Arthur", 22222222222));
            clientes.Add(new Cliente("Emily", 33333333333));
            return clientes;
        }
    }
}
