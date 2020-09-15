class Vendedor : Funcionario {

    private double comissao;

    public Vendedor(string nome, string matricula, double salario_base, double comissao) : base (nome, matricula, salario_base) {
        this.comissao = comissao;
    }

    public override double CalculaSalario() {
        return this.SalarioBase + this.comissao;
    }

}