using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula63_Exercicio2.Servicos;

namespace Aula63_Exercicio2.Telas
{
    public partial class Carros : Form
    {
        List<Carro> carros = CarroRepository.InitializeCarros();
        List<Cliente> clientes = ClienteRepository.InitializeCliente();

        public Carros()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = clientes[comboBox1.SelectedIndex];
            Carro carro = carros[comboBox2.SelectedIndex];

            double valorPorHora = double.Parse(txtValorPorHora.Text);
            DateTime dataInicial = DateTime.Parse(txtDataInicial.Text);
            DateTime dataEntrega = DateTime.Parse(txtDataDeEntrega.Text);

            LocacaoDeCarro locacao = new LocacaoDeCarro(cliente, carro, dataInicial, dataEntrega, valorPorHora);

            locacao.FinalizarLocacao();

            lblCliente.Text = locacao.Cliente.ToString();
            lblCarro.Text = locacao.Carro.ToString();
            lblDuracao.Text = $"{Math.Ceiling(locacao.Duracao.TotalDays).ToString()} Dia";

            lblValorTotal.Text = $"Valor da locação: {locacao.ValorTotal.ToString()}";

            //MessageBox.Show("Erro");
            //lblResultado.Text = $"{Cliente} | {Carros} | {ValorTotal}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Carros_Load(object sender, EventArgs e)
        {
            //List<Cliente> clientes = new List<Cliente>();

            /*clientes.Add(new Cliente("João Pedro", 44444444444));
            clientes.Add(new Cliente("Ricardo", 11111111111));
            clientes.Add(new Cliente("Ana Luiza", 22222222222));
            clientes.Add(new Cliente("Joana ", 33333333333));*/

            foreach (Cliente cliente in clientes)
            {
                comboBox1.Items.Add(cliente);
            }

            //List<Carro> carros = new List<Carro>();
            /*carros.Add(new Carro("Ford", "Fiesta", "CSD2343"));
            carros.Add(new Carro("Chevrolet", "S10", "KCS4843"));
            carros.Add(new Carro("Volkswagen", "Golf", "GVB2673"));
            carros.Add(new Carro("Nissan", "Match", "UVS3843"));
            carros.Add(new Carro("Ford", "Focus", "KGH5436"));*/

            foreach (Carro carro in carros)
            {
                comboBox2.Items.Add(carro);
            }
        }
    }
}
