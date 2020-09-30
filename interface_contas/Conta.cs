abstract class Conta {

    protected double saldo;
    private string numeroDaConta;
    private string nomeCompletoDoTitular;

    public Conta(string nomeCompletoDoTitular, string numeroDaConta) {
        this.nomeCompletoDoTitular = nomeCompletoDoTitular;
        this.numeroDaConta = numeroDaConta;
    }

    public string Depositar(double vlrDoDeposito) {
        this.saldo += vlrDoDeposito;

        return "Foi depositado na conta o valor de R$" + this.saldo;
    }

    public abstract string Sacar(double vlrDoSaque);

    public string Relatorio() {
        return "Nome do titular: " + this.nomeCompletoDoTitular + ". Número da conta: " + this.numeroDaConta + ". Saldo: " + this.saldo;
    }

}