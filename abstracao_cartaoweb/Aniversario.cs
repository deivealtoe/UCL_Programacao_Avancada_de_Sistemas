class Aniversario : CartaoWeb {

    public Aniversario(string destinatario) : base (destinatario) {}

    public override string ExibirMensagem() {
        return "Feliz aniversário, " + this.Destinatario + "!";
    }

}