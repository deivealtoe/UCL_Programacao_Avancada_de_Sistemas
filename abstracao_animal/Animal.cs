using System;

abstract class Animal {

    private string nome;
    public string Nome {
        get { return nome; }
        set { nome = value; }
    }

    private DateTime dataNascimento;
    public DateTime DataNascimento {
        get { return dataNascimento; }
        set { dataNascimento = value; }
    }

    private float massaEmKg;
    public float MassaEmKg {
        get { return massaEmKg; }
        set { massaEmKg = value; }
    }

    private float capacidadeEstomagoEmKg;
    public float CapacidadeEstomago {
        get { return capacidadeEstomagoEmKg; }
        set { capacidadeEstomagoEmKg = value; }
    }

    public int GetIdade() {
        return dataNascimento.Year - DateTime.Now.Year;
    }

    public bool Comer(float qtdComidaEmKg) {
        return this.capacidadeEstomagoEmKg < qtdComidaEmKg ? true : false;
    }

}