using System;

class Program{
    static void Main(string[] args) {

        Conta minhaPoupanca = new ContaPoupanca("Deivisson", "123");

        Console.WriteLine(minhaPoupanca.Depositar(200));
        Console.WriteLine(minhaPoupanca.Sacar(150));
        Console.WriteLine(minhaPoupanca.Relatorio());

        Console.WriteLine();

        ContaCorrente minhaCorrente = new ContaCorrente("Larissa", "321");

        Console.WriteLine(minhaCorrente.Depositar(350));
        Console.WriteLine(minhaCorrente.Sacar(25));
        Console.WriteLine(minhaCorrente.Tributar());
        Console.WriteLine(minhaCorrente.Relatorio());

        Console.WriteLine();

        ContaInvestimento minhaInvestimento = new ContaInvestimento("João Maria", "159");

        Console.WriteLine(minhaInvestimento.Depositar(400));
        Console.WriteLine(minhaInvestimento.Sacar(350));
        Console.WriteLine(minhaInvestimento.Tributar());
        Console.WriteLine(minhaInvestimento.Relatorio());

    }
    
}