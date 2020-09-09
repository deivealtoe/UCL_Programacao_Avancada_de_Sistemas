using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Digite seu CPF sem pontuações:");
    string cpfCompleto = Console.ReadLine();
    
    char[] cpfDigitos = cpfCompleto.ToCharArray();
    
    // Calculando primeiro dígito
    int contMultiplicador = 10;
    int contVetor = 0;
    int somatorio = 0;
    while (contMultiplicador > 1) {
      somatorio += int.Parse(cpfDigitos[contVetor].ToString()) * contMultiplicador;
      
      contMultiplicador--;
      contVetor++;
    }
    
    float digitoUmCalculado = (((float)(somatorio * 10)) % 11);
    
    // Calculando segundo dígito
    somatorio = int.Parse(cpfDigitos[9].ToString()) * 11;
    contMultiplicador = 10;
    contVetor = 0;
    while (contMultiplicador > 1) {
      somatorio += int.Parse(cpfDigitos[contVetor].ToString()) * contMultiplicador;
      
      contMultiplicador--;
      contVetor++;
    }
    
    float digitoDoisCalculado = (((float)(somatorio * 10)) % 11);
    
    if (digitoUmCalculado == int.Parse(cpfDigitos[9].ToString()) 
        && digitoDoisCalculado == int.Parse(cpfDigitos[10].ToString())) {
      Console.WriteLine("Válido");
    } else {
      Console.WriteLine("Inválido");
    }
    
  }
}