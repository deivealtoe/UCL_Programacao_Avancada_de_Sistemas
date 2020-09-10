abstract class Mamifero : Animal {

    private int qtdMesesParaCompletarAmamentacao;
    public int QtdMesesParaCompletarAmamentacao {
        get { return qtdMesesParaCompletarAmamentacao; }
        set { qtdMesesParaCompletarAmamentacao = value; }
    }

    public abstract string Parir();

}