using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Digite um número:");
    int numeroDigitado = int.Parse(Console.ReadLine());
    
    int qtdDivisores = 0;
    for (int divisor = 1; divisor <= numeroDigitado; divisor++) {
      if (numeroDigitado % divisor == 0) {
        qtdDivisores++;
      }
    }
    
    if (qtdDivisores > 2) {
      Console.WriteLine("O número informado não é PRIMO");
    } else {
      Console.WriteLine("O número informado é PRIMO");
    }
    
  }
}