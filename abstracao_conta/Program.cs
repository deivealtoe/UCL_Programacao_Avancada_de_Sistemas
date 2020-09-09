using System;

class MainClass {
  public static void Main (string[] args) {
    
    Conta cc1 = new ContaCorrente();
    cc1.Titular = "Maria Joaquina";
    cc1.Numero = 123;

    Conta cp1 = new ContaPoupanca();
    cp1.Titular = "João Mario";
    cp1.Numero = 321;

    cc1.Depositar(100);
    cp1.Depositar(150);

    Console.WriteLine(cc1.Relatorio());
    Console.WriteLine(cp1.Relatorio());

    cc1.Sacar(25);
    cp1.Sacar(50);

    Console.WriteLine(cc1.Relatorio());
    Console.WriteLine(cp1.Relatorio());

  }
}