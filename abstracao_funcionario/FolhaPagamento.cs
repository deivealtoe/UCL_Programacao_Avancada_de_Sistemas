using System;
using System.Collections.Generic;

class FolhaPagamento {

    static void Main(string[] args) {

        List<Funcionario> funcionarios = new List<Funcionario>();

        funcionarios.Add(new Assistente("Carlos João", "abc123", 1000));
        funcionarios.Add(new Gerente("Astolfo Carlos", "def456", 800));
        funcionarios.Add(new Vendedor("João Astolfo", "ghi789", 700, 300));

        double somatorio = 0;
        foreach (Funcionario funcionario in funcionarios) {
            somatorio += funcionario.CalculaSalario();
        }

        Console.WriteLine("O total dos salários é de R$" + somatorio);

    }

}

/*

    Os conceitos de POO foram: polimorfismo e abstração
    - Com o polimorfismo, criei uma classe abstrata para ser usada como "modelo"
    - para outras três classes: Assistente, Vendedor e Gerente.

*/