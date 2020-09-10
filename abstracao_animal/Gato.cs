using System;

class Gato : Mamifero {

    private string raca;
    private bool castrado;

    public Gato(string nome, DateTime dataNascimento, string raca) {
        this.Nome = nome;
        this.DataNascimento = dataNascimento;
        this.raca = raca;
    }

    public override string Parir() {
        return "Saindo vários gatchíneos!";
    }

}