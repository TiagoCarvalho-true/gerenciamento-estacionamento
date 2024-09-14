using System;
using System.Collections.Generic;

public class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        this.veiculos = new List<string>();
    }

    public void AdicionarVeiculo(string placa)
    {
        veiculos.Add(placa);
        Console.WriteLine($"Veículo com placa {placa} adicionado.");
    }

    public void RemoverVeiculo(string placa, int horas)
    {
        if (veiculos.Contains(placa))
        {
            veiculos.Remove(placa);
            decimal valorTotal = precoInicial + (precoPorHora * horas);
            Console.WriteLine($"Veículo com placa {placa} removido. Valor a pagar: R${valorTotal}");
        }
        else
        {
            Console.WriteLine("Veículo não encontrado.");
        }
    }

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

