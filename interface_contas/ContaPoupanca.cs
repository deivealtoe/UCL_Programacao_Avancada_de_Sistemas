class ContaPoupanca : Conta {

    public ContaPoupanca (string nomeCompletoDoTitular, string numeroDaConta) : base (nomeCompletoDoTitular, numeroDaConta) {}

    public override string Sacar(double vlrDoSaque) {
        if (this.saldo >= vlrDoSaque) {
            this.saldo -= vlrDoSaque;

            return "Foi retirado o valor de R$" + vlrDoSaque;
        }

        return "Valor de saque maior que saldo atual";
    }

}