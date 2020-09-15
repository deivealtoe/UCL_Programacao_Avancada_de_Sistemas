class Natal : CartaoWeb {

    public Natal(string destinatario) : base (destinatario) {}

    public override string ExibirMensagem() {
        return "Feliz natal, " + this.Destinatario + "!";
    }

}