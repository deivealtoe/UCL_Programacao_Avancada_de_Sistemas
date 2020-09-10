using System;

class Cachorro : Mamifero {

    private string raca;
    private bool castrado;
    public bool Castrado {
        get { return castrado; }
        set { castrado = value; }
    }

    public Cachorro(string nome, DateTime dataNascimento, string raca) {
        this.Nome = nome;
        this.DataNascimento = dataNascimento;
        this.raca = raca;
    }

    public override string Parir() {
        return "Saindo vários catchoríneos!";
    }

}