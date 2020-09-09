using System;

class MainClass {
  public static void Main (string[] args) {
    
    // 2 * 2 * 2 == 8 posições >> 8 / 3 == 2 posições em cada dimensão
    int[,,] matrizTridimensional = {{{1, 2}, {3, 4}}, {{5, 6}, {7, 8}}};
    
    // Dividido por 3 pois a matriz é tridimensional
    for (int j = 0; j < matrizTridimensional.Length / 3; j++) {
      for (int k = 0; k < matrizTridimensional.Length / 3; k++) {
        for (int u = 0; u < matrizTridimensional.Length / 3; u++) {
          if (verifNumeroPar(matrizTridimensional[j, k, u])) {
            Console.WriteLine("Número par da matriz: " + matrizTridimensional[j, k, u]);
          }
        }
      }
    }
    
  }
  
  public static bool verifNumeroPar(int numero) {
    return numero % 2 == 0 ? true : false;
  }
}