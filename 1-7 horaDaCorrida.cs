using System;

class augutoRun {
  public static void Main (string[] args) {
    
    string[] entrada = Console.ReadLine().Split(" ");
    int totalVoltas = int.Parse(entrada[0]);
    int placasPista = int.Parse(entrada[1]);
    
    int totalPlacas = placasPista * totalVoltas;
    
    for(int i = 10; i < 100; i += 10)
    {
      double result = (double)totalPlacas / 100 * i;
      Console.Write(Math.Ceiling(result) + " ");
    }
  }
}