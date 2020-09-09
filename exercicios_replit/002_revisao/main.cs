using System;

class MainClass {
  public static void Main (string[] args) {
    
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
    
  }
}