using System;

class oCardapio {
  public static void Main (string[] args) {
    string[] disponivel = Console.ReadLine().Split(" ");
    int Ca = int.Parse(disponivel[0]);
    int Ba = int.Parse(disponivel[1]);
    int Pa = int.Parse(disponivel[2]);
    string[] requisitado = Console.ReadLine().Split(" ");
    int Cr = int.Parse(requisitado[0]);
    int Br = int.Parse(requisitado[1]);
    int Pr = int.Parse(requisitado[2]);
    
      int numeroPizzasFaltantes = 0;
          if (Ca - Cr < 0)
          {
          numeroPizzasFaltantes = (Ca - Cr) * -1;
          }
    
      int numeroSaladasFaltantes = 0;
          if (Ba - Br < 0)
          {
          numeroSaladasFaltantes = (Ba - Br) * -1;
          }
    
      int numeroMassasFaltantes = 0;
          if (Pa - Pr < 0)
          {
          numeroMassasFaltantes = (Pa - Pr) * -1;
          }
    
      int totalRefeicoesFaltantes = numeroMassasFaltantes + numeroSaladasFaltantes + numeroPizzasFaltantes;
    Console.WriteLine(totalRefeicoesFaltantes);
  }
}