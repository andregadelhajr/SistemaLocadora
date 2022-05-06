using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula63_Exercicio2.Servicos
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }

        public Carro(string modelo, string marca, string placa)
        {
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
        }

        public override string ToString()
        {
            return Modelo + " - " + Marca + " - " + Placa.ToString();
        }
    }

    public class CarroRepository
    {
        public static List<Carro> InitializeCarros()
        {
            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro("Ford", "Maverick", "CSD2343"));
            carros.Add(new Carro("Ford", "Ranger", "KGH5436")); 
            carros.Add(new Carro("Volkswagen", "Fox", "GVB2673"));
            carros.Add(new Carro("Mitsubishi", "Lancer", "UVS3843"));
            carros.Add(new Carro("Chevrolet", "Camaro", "KCS4843"));
            return carros;
        }
    }
}
