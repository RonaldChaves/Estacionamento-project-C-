using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento_project.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        //  Constructor >> Estacionamento
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        /// Adiciona um veiculo a List<string> veiculos
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.Clear();

            Console.WriteLine($"Digite a placa do carro que sera adicionado:");
            string? novoVeiculo = Console.ReadLine();

            if (veiculos.Any(x => x.Equals(novoVeiculo, StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine($"O veiculo {novoVeiculo} ja esta estacionado!");

            }
            else
            {
                veiculos.Add(novoVeiculo);
                Console.WriteLine($"Veiculo adicionado com sucesso!");
            }

            Thread.Sleep(2000);
        }

        /// <summary>
        /// Remove um veiculo da List<string> veiculos
        /// </summary>
        public void RemoverVeiculo(decimal valorHora, decimal entrada)
        {
            Console.Clear();

            Console.WriteLine("Digite a placa do veiculo que deseja remover:");

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Veiculo estacionado: {veiculo}");
            }
            Console.WriteLine("");

            string? placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa?.ToUpper()))
            {
                veiculos.Remove(placa);
                Console.WriteLine("Quantas horas o carro ficou no estacionamento?");
                int horas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"O valor total a pagar pelo estacionamento eh: R${(horas * valorHora) + entrada}");

            }
            else
            {
                Console.WriteLine($"O veiculo {placa} nao existe no estacionamento.");
            }

            Thread.Sleep(2000);
        }

        /// <summary>
        /// Mostra todos os carros da List<string> veiculos
        /// </summary>
        public void MostrarLista()
        {
            Console.Clear();

            Console.WriteLine("Esta eh a lista com todos os carros estacionados: ");

            for (var i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"Vaga: {i + 1} | Carro: {veiculos.ElementAt(i).ToUpper()}");
            }

            Thread.Sleep(2000);
        }
    }
}