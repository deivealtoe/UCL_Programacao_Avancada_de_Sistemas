using System;

class MainClass {
  public static void Main (string[] args) {
    Ponto meuPonto = new Ponto(1, 2);
    Ponto outroPonto = new Ponto(3, 4);
    
    Ponto somaDosPontos = meuPonto + outroPonto;
    Console.WriteLine(somaDosPontos.getXY());
    
    Ponto subtracaoDosPontos = meuPonto - outroPonto;
    Console.WriteLine(subtracaoDosPontos.getXY());
    
    meuPonto++;
    Console.WriteLine(meuPonto.getXY());
    
    meuPonto--;
    Console.WriteLine(meuPonto.getXY());
  }
}