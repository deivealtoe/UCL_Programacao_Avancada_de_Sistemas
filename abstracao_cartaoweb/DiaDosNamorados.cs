class DiaDosNamorados : CartaoWeb {

    public DiaDosNamorados(string destinatario) : base (destinatario) {}

    public override string ExibirMensagem() {
        return "Feliz dia dos namorados, " + this.Destinatario + "!";
    }

}