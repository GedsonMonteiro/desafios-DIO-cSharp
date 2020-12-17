using System;

class pizzaFda {
  public static void Main (string[] args) {
    string[] primeiraEntrada = Console.ReadLine().Split(" ");
    int pessoas = int.Parse(primeiraEntrada[0]);
    int numeroDeDatasConsideradas = int.Parse(primeiraEntrada[1]);
    
    string dataEscolhida = "";
    bool todosPodem = true;
    for(int i = 1; i <= numeroDeDatasConsideradas; i++)
    {
      todosPodem = true;
      string[] segundaEntrada = Console.ReadLine().Split(" ");
      dataEscolhida = segundaEntrada[0];
      for(int a = 1; a <= pessoas; a++)
      {
        int convidado = int.Parse(segundaEntrada[a]);
        if(convidado == 0)
        {
          todosPodem = false;
          break;
        }
      }
      if(todosPodem)
      {
        Console.WriteLine(dataEscolhida);
        break;
      }
    }
    
      if(!todosPodem)
      Console.WriteLine("Pizza antes de FdA");
  }
}