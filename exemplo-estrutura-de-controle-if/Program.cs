public class Program
{
  public static void Main()
  {
    Console.WriteLine("Informe o raio de um círculo (deve ser um número inteiro)");
    string? response = Console.ReadLine();
    int radius = 0;
    var canConvert = Int32.TryParse(response, out radius);

    if (canConvert)
    {
      const double pi = 3.14159;


      double circumference = pi * (2 * radius);

      Console.WriteLine("A circunferencia de um circulo com o raio " + radius + " é igual a " + circumference);
    }
    else
    {
      Console.WriteLine("O texto digitado não é um número inteiro.");

    }
  }
}

//No código acima, o programa define se calcula e imprime a circunferência
//de acordo com o valor da variável canConvert. 
//Assim, conseguimos alterar a ordem na qual as instruções
//são executadas de acordo com o valor informado pelo usuário.