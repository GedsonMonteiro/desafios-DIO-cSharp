using System;

class conversaoTempo {
  public static void Main (string[] args) {
    int tempoSegundos = int.Parse(Console.ReadLine());
    
    int horas = tempoSegundos / 3600;
    int minutos = (tempoSegundos % 3600) / 60;
    int segundos = (tempoSegundos % 3600) % 60;
    
    Console.Write($"{horas}:{minutos}:{segundos}");
  }
}