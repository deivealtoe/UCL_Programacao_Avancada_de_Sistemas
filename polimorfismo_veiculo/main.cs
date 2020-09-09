using System;

class MainClass {
  public static void Main (string[] args) {
    
    Veiculo veiculoA = new Automovel("Ferrari");
    Veiculo veiculoB = new Aeronave("Boeing-747");

    Console.WriteLine(veiculoA.Mover());
    Console.WriteLine(veiculoB.Mover());

    Console.WriteLine(veiculoA.Parar());
    Console.WriteLine(veiculoB.Parar());

  }
}