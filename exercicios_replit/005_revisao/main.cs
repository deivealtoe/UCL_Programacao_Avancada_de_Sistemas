using System;

class MainClass {
  public static void Main (string[] args) {
    
    int somatorio = 0;
    
    while (somatorio < 200) {
      Console.Write("Digite um número inteiro: ");
      somatorio += int.Parse(Console.ReadLine());
      
      Console.WriteLine("Somatório atual: " + somatorio);
    }
    
  }
}