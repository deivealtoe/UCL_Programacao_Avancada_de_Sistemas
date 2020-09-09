using System;

class MainClass {
  public static void Main (string[] args) {
    Circunferencia minhaCircunferencia = new Circunferencia(new Ponto(1, 2), 3);
    Circunferencia outraCircunferencia = new Circunferencia(new Ponto(2, 3), 4);
    
    Circunferencia circunferenciaSomada = minhaCircunferencia + outraCircunferencia;
    Console.WriteLine(circunferenciaSomada.getCircunferenciaString());
    
    Console.WriteLine(circunferenciaSomada.getArea());
    Console.WriteLine(minhaCircunferencia > outraCircunferencia);
    Console.WriteLine(minhaCircunferencia < outraCircunferencia);
    Console.WriteLine(minhaCircunferencia >= outraCircunferencia);
    Console.WriteLine(minhaCircunferencia <= outraCircunferencia);
  }
}