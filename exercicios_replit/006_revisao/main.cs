using System;

class MainClass {
  public static void Main (string[] args) {
    
    int[] vetorDeInteiros = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17};
    
    int somatorio = 0;
    foreach (int inteiro in vetorDeInteiros) {
      if (verifNumeroPrimo(inteiro)) {
        somatorio += inteiro;
      }
    }
    
    Console.WriteLine("O somatório dos números primos é igual a " + somatorio);
    
  }
  
  // Função para verificar se um número é primo ou não
  public static bool verifNumeroPrimo(int inteiro) {
    
    int qtdDivisores = 0;
    for (int divisor = 1; divisor <= inteiro; divisor++) {
      if (inteiro % divisor == 0) {
        qtdDivisores++;
      }
    }
    
    return qtdDivisores == 2 ? true : false;
    
  }
}