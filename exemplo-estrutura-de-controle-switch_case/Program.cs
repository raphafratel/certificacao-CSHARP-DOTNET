public class Program
{
  public static void Main()
  {
    Console.WriteLine("Digite o número de lados do poligono");
    string? response = Console.ReadLine();
    int sideCount = 0;
    var canConvert = Int32.TryParse(response, out sideCount);

    if (canConvert)
    {
      var name = string.Empty;
      switch (sideCount)
      {
        case < 3:
          name = "Não é um polígono";
          break;
        case 3:
          name = "Triangulo";
          break;
        case 4:
          name = "Quadrado";
          break;
        case 5:
          name = "Pentágono";
          break;
        default:
          name = "Polígono não identificado";
          break;
      }
      Console.WriteLine(name);
    }
    else
    {
      Console.WriteLine("O texto digitado não é um número inteiro");
    }
  }
}