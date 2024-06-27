
using Estacionamento_project.Models;

bool exibirMenu = true;

Console.WriteLine("Digite o valor da entrada do estacionamento:");

decimal valorEntrada = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor por hora do estacionamento:");

decimal valorPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(valorEntrada, valorPorHora);


while (exibirMenu)
{

    Console.Clear();
    Console.WriteLine("Escolha uma das opcoes abaixo:");
    Console.WriteLine("1 - Adicionar carro no estacionamento ->");
    Console.WriteLine("2 - Remover carro do estacionamento ->");
    Console.WriteLine("3 - Listar todos os carros estacionados ->");
    Console.WriteLine("4 - Sair do estacionamento");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo(valorPorHora,valorEntrada);
            break;
        case "3":
            estacionamento.MostrarLista();
            break;
        case "4":
            Thread.Sleep(1000);
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opcao nao aceita ou incorreta!!");
            break;

    }

}