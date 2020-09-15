class Assistente : Funcionario {

    public Assistente(string nome, string matricula, double salario_base) : base (nome, matricula, salario_base) {}

    public override double CalculaSalario() {
        return this.SalarioBase;
    }

}