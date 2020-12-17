using System;

class idadeDias {
  public static void Main (string[] args) {
    const int diasAno = 365; 
    const int diasMes = 30;
    var idade = int.Parse(Console.ReadLine());
    var anos = idade / diasAno;
    var meses = (idade % diasAno) / diasMes; 
    var dias = (idade % diasAno) % diasMes;

    Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
  }
}