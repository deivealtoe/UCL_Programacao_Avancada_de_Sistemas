using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Você é maior de idade? [s/n]");
    bool maiorDeIdade = Console.ReadLine() == "s" ? true : false;
    
    Console.WriteLine("Você é estudante do curso de Sistemas de Informação? [s/n]");
    bool estudanteDeSi = Console.ReadLine() == "s" ? true : false;
    
    if (maiorDeIdade && estudanteDeSi) {
    
      Console.WriteLine("Escreva uma frase aleatória: ");
      string fraseDigitada = Console.ReadLine();
      
      string[] frases = {"Frase 1", "Frase 2", "Frase 3", "Frase 4", "Frase 5"};
      
      bool acertou = false;
      for (int i = 0; i < 5; i++) {
        if (frases[i] == fraseDigitada) {
          acertou = true;
        }
      }
      
      if (acertou) {
        Console.WriteLine("Acertou!");
      } else {
        Console.WriteLine("Não acertou");
      }
    
    } else {
      
      Console.WriteLine("Não pode participar do jogo!");
      
    }
    
  }
}