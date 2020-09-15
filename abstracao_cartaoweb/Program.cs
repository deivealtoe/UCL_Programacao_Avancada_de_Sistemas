using System;
using System.Collections.Generic;

class Program {

    static void Main(string[] args) {

        List<CartaoWeb> lista_de_cartoes = new List<CartaoWeb>();

        lista_de_cartoes.Add(new Natal("Abc"));
        lista_de_cartoes.Add(new Aniversario("Def"));
        lista_de_cartoes.Add(new DiaDosNamorados("Ghi"));

        foreach (CartaoWeb cartao_web in lista_de_cartoes) {
            Console.WriteLine(cartao_web.ExibirMensagem());
        }

    }

}