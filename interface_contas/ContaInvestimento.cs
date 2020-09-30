class ContaInvestimento : Conta {

    public ContaInvestimento(string nomeCompletoDoTitular, string numeroDaConta) : base (nomeCompletoDoTitular, numeroDaConta) {}

    public override string Sacar(double vlrDoSaque) {
        double taxaDeRetirada = vlrDoSaque * 0.1;

        if (this.saldo >= taxaDeRetirada + vlrDoSaque) {
            this.saldo -= taxaDeRetirada + vlrDoSaque;

            return "Foi retirado o valor de R$" + vlrDoSaque + " juntamente com uma taxa de retirada de R$" + taxaDeRetirada + " (10% do valor do saque)";
        }

        return "Valor de saque maior que saldo atual";
    }

    public string Tributar() {
        this.saldo -= this.saldo * 0.005;

        return "Conta tributada com o valor de R$" + this.saldo * 0.015 + " descontado diretamente do saldo";
    }

}