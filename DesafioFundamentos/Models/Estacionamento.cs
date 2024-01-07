namespace DesafioFundamentos.Models
{
  public class Estacionamento
  {
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
      this.precoInicial = precoInicial;
      this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {

      //IMPLEMENTADO
      Console.WriteLine("Digite a placa do veículo para estacionar:");
      string placa = Console.ReadLine();
      veiculos.Add(placa);
      Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso!");
    }

    public void RemoverVeiculo()
    {
      Console.WriteLine("Digite a placa do veículo para remover:");

      //IMPLEMENTADO
      string placa = Console.ReadLine();

      // Verifica se o veículo existe
      if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
      {
        bool entradaValida = false;
        int horas = 0;

        do
        {
          Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

          //IMPLEMENTADO 
          string horasEstacionado = Console.ReadLine();

          if (int.TryParse(horasEstacionado, out horas) && horas >= 0)
          {
            entradaValida = true;
          }
          else
          {
            Console.WriteLine("Por favor, digite um número válido de horas (não negativo).");
          }

        } while (!entradaValida);

        Console.WriteLine($"O veículo {placa} permaneceu {horas} horas estacionado");

        decimal valorTotal = precoInicial + precoPorHora * horas;

        //IMPLEMENTADO
        veiculos.Remove(placa);
        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
      }
      else
      {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
      }
    }


    public void ListarVeiculos()
    {
      // Verifica se há veículos no estacionamento
      if (veiculos.Any())
      {
        Console.WriteLine("Os veículos estacionados são:");
        //IMPLEMENTADO
        foreach (string veiculosEstacionados in veiculos)
        {
          Console.WriteLine($"{veiculosEstacionados}");
        }
      }
      else
      {
        Console.WriteLine("Não há veículos estacionados.");
      }
    }
  }
}
