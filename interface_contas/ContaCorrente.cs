class ContaCorrente : Conta, Tributos {

    private double taxaAdministrativa = 1.5;

    public ContaCorrente (string nomeCompletoDoTitular, string numeroDaConta) : base (nomeCompletoDoTitular, numeroDaConta) {}

    public override string Sacar(double vlrDoSaque) {
        if (this.saldo >= this.taxaAdministrativa + vlrDoSaque) {
            this.saldo -= this.taxaAdministrativa + vlrDoSaque;

            return "Foi retirado o valor de R$" + vlrDoSaque + " juntamente com uma taxa administrativa de R$" + this.taxaAdministrativa;
        }

        return "Valor de saque maior que saldo atual";
    }

    public string Tributar() {
        this.saldo -= this.saldo * 0.005;

        return "Conta tributada com o valor de R$" + this.saldo * 0.005 + " descontado diretamente do saldo";
    }

}