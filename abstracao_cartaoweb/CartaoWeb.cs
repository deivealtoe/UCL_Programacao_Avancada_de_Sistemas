abstract class CartaoWeb {

    private string destinatario;
    public string Destinatario {
        get { return this.destinatario; }
        set { this.destinatario = value; }
    }

    public CartaoWeb(string destinatario) {
        this.destinatario = destinatario;
    }

    public abstract string ExibirMensagem();

}