using System;

class dobby {
  public static void Main (string[] args) {
    var minutosFinais = int.Parse(Console.ReadLine());
    string[] entrada = Console.ReadLine().Split(" ");
    int minutosPresenteA = int.Parse(entrada[0]);
    int minutosPresenteB = int.Parse(entrada[1]);
    int tempoFabricacao = minutosPresenteA + minutosPresenteB;

      if (tempoFabricacao > minutosFinais)
        Console.WriteLine("Deixa para amanha!");
      else
        Console.WriteLine("Farei hoje!");
  }
}