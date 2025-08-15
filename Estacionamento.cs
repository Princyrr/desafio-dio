using System;
using System.Collections.Generic;
using System.Linq;

public class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    // Adiciona veículo à lista
    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();
        veiculos.Add(placa);
        Console.WriteLine($"Veículo {placa} adicionado com sucesso!");
    }

    // Remove veículo e calcula valor a ser cobrado
    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine();

        if (veiculos.Any(v => v.Equals(placa, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas;
            while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
            {
                Console.WriteLine("Por favor, digite um número válido de horas:");
            }

            decimal valorTotal = precoInicial + (precoPorHora * horas);

            veiculos.Remove(placa);
            Console.WriteLine($"Veículo {placa} removido. Valor total: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
        }
    }

    // Lista todos os veículos estacionados
    public void ListarVeiculos()
    {
        if (veiculos.Count > 0)
        {
            Console.WriteLine("Veículos estacionados:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
