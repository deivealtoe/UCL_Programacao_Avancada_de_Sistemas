abstract class Funcionario {

    private string nome;
    private string matricula;
    private double salario_base;
    public double SalarioBase {
        get { return this.salario_base; }
        set { this.salario_base = value; }
    }

    public Funcionario(string nome, string matricula, double salario_base) {
        this.nome = nome;
        this.matricula = matricula;
        this.salario_base = salario_base;
    }

    public abstract double CalculaSalario();

}